using ElectronNET.API;

namespace LANMaker
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //rest of your ConfigureServices method
            services.AddElectron();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //...

            // Open the Electron-Window here
            Task.Run(async () => await Electron.WindowManager.CreateWindowAsync());
        }
    }
}
