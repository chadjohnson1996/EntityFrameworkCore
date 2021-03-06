﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Scaffolding.Internal
{
    public class ReverseEngineerScaffolderTest
    {
        [Fact]
        public void Save_works()
        {
            using (var directory = new TempDirectory())
            {
                var scaffolder = CreateScaffolder();
                var scaffoldedModel = new ScaffoldedModel
                {
                    ContextFile = new ScaffoldedFile
                    {
                        Path = "TestContext.cs",
                        Code = "// TestContext"
                    },
                    EntityTypeFiles =
                    {
                        new ScaffoldedFile
                        {
                            Path = "TestEntity.cs",
                            Code = "// TestEntity"
                        }
                    }
                };

                var result = scaffolder.Save(scaffoldedModel, directory.Path, "Models", overwriteFiles: false);

                var contextPath = Path.Combine(directory.Path, "Models", "TestContext.cs");
                Assert.Equal(contextPath, result.ContextFile);
                Assert.Equal("// TestContext", File.ReadAllText(contextPath));

                Assert.Equal(1, result.EntityTypeFiles.Count);
                var entityTypePath = Path.Combine(directory.Path, "Models", "TestEntity.cs");
                Assert.Equal(entityTypePath, result.EntityTypeFiles[0]);
                Assert.Equal("// TestEntity", File.ReadAllText(entityTypePath));
            }
        }

        [Fact]
        public void Save_throws_when_existing_files()
        {
            using (var directory = new TempDirectory())
            {
                var contextPath = Path.Combine(directory.Path, "TestContext.cs");
                File.WriteAllText(contextPath, "// Old");

                var entityTypePath = Path.Combine(directory.Path, "TestEntity.cs");
                File.WriteAllText(entityTypePath, "// Old");

                var scaffolder = CreateScaffolder();
                var scaffoldedModel = new ScaffoldedModel
                {
                    ContextFile = new ScaffoldedFile
                    {
                        Path = "TestContext.cs",
                        Code = "// TestContext"
                    },
                    EntityTypeFiles =
                    {
                        new ScaffoldedFile
                        {
                            Path = "TestEntity.cs",
                            Code = "// TestEntity"
                        }
                    }
                };

                var ex = Assert.Throws<OperationException>(
                    () => scaffolder.Save(scaffoldedModel, directory.Path, outputPath: null, overwriteFiles: false));

                Assert.Equal(
                    DesignStrings.ExistingFiles(
                        directory.Path,
                        string.Join(CultureInfo.CurrentCulture.TextInfo.ListSeparator, "TestContext.cs", "TestEntity.cs")),
                    ex.Message);
            }
        }

        [Fact]
        public void Save_works_when_overwriteFiles()
        {
            using (var directory = new TempDirectory())
            {
                var path = Path.Combine(directory.Path, "Test.cs");
                File.WriteAllText(path, "// Old");

                var scaffolder = CreateScaffolder();
                var scaffoldedModel = new ScaffoldedModel
                {
                    ContextFile = new ScaffoldedFile
                    {
                        Path = "Test.cs",
                        Code = "// Test"
                    }
                };

                var result = scaffolder.Save(scaffoldedModel, directory.Path, outputPath: null, overwriteFiles: true);

                Assert.Equal(path, result.ContextFile);
                Assert.Equal("// Test", File.ReadAllText(path));
            }
        }

        [Fact]
        public void Save_throws_when_readonly_files()
        {
            using (var directory = new TempDirectory())
            {
                var contextPath = Path.Combine(directory.Path, "TestContext.cs");
                File.WriteAllText(contextPath, "// Old");

                var entityTypePath = Path.Combine(directory.Path, "TestEntity.cs");
                File.WriteAllText(entityTypePath, "// Old");

                var originalAttributes = File.GetAttributes(contextPath);
                File.SetAttributes(contextPath, originalAttributes | FileAttributes.ReadOnly);
                File.SetAttributes(entityTypePath, originalAttributes | FileAttributes.ReadOnly);
                try
                {
                    var scaffolder = CreateScaffolder();
                    var scaffoldedModel = new ScaffoldedModel
                    {
                        ContextFile = new ScaffoldedFile
                        {
                            Path = "TestContext.cs",
                            Code = "// TestContext"
                        },
                        EntityTypeFiles =
                    {
                        new ScaffoldedFile
                        {
                            Path = "TestEntity.cs",
                            Code = "// TestEntity"
                        }
                    }
                    };

                    var ex = Assert.Throws<OperationException>(
                        () => scaffolder.Save(scaffoldedModel, directory.Path, outputPath: null, overwriteFiles: true));

                    Assert.Equal(
                        DesignStrings.ReadOnlyFiles(
                            directory.Path,
                            string.Join(CultureInfo.CurrentCulture.TextInfo.ListSeparator, "TestContext.cs", "TestEntity.cs")),
                        ex.Message);
                }
                finally
                {
                    File.SetAttributes(contextPath, originalAttributes);
                    File.SetAttributes(entityTypePath, originalAttributes);
                }
            }
        }

        private static IReverseEngineerScaffolder CreateScaffolder()
        {
            var cSharpUtilities = new CSharpUtilities();

            return new ReverseEngineerScaffolder(
                new FakeDatabaseModelFactory(),
                new FakeScaffoldingModelFactory(new TestOperationReporter()),
                new ScaffoldingCodeGeneratorSelector(
                    new[]
                    {
                        new CSharpScaffoldingGenerator(
                            new CSharpDbContextGenerator(
#pragma warning disable CS0618 // Type or member is obsolete
                                Enumerable.Empty<IScaffoldingProviderCodeGenerator>(),
#pragma warning restore CS0618 // Type or member is obsolete
                                new[]{ new TestProviderCodeGenerator() },
                                new AnnotationCodeGenerator(new AnnotationCodeGeneratorDependencies()),
                                cSharpUtilities),
                            new CSharpEntityTypeGenerator(cSharpUtilities))
                    }),
                cSharpUtilities);
        }
    }
}
