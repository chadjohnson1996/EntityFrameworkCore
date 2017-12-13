using System;
using System.Collections.Generic;
using System.Text;
using FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext
{
    public class FoundationContext : Cas_TestContext
    {

        public string ConnectionString { get; }
        /// <summary>
        /// creates a foundation context to connect to the given database
        /// </summary>
        /// <param name="connectionString">the database to connect to</param>
        public FoundationContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
