class Program
{
    public static void Main()
    {
        var builder = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseWebRoot("Content")
        .UseStartup<Startup>()
        .Build();

        builder.Run();
    }
}