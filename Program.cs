namespace keep_alive_bymake_nova
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddHostedService<WindowsWorker>();

            var host = builder.Build();
            host.Run();
        }
    }
}