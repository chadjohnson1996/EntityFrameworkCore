using FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {

            MainAsync(args).Wait();

        }

        static async Task MainAsync(string[] args)
        {
            var context = new FoundationContext("test");

            var result = await context.Customers.FirstOrDefaultAsync();
        }
    }
}
