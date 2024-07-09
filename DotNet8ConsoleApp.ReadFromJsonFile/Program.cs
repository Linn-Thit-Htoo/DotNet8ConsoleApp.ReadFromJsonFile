using Microsoft.Extensions.Configuration;

namespace DotNet8ConsoleApp.ReadFromJsonFile;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();

        //var connStr = configuration["ConnectionStrings:DbConnection"];
        var connStr = configuration.GetConnectionString("DbConnection");
        Console.WriteLine(connStr);
    }
}
