using Crypto.Wallet.Windows.App.Telas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Crypto.Wallet.Windows.App.Services.Interfaces;
using Crypto.Wallet.Windows.App.Services;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Net.Security;

namespace Crypto.Wallet.Windows.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            ConfigureServices(services);
            services.AddScoped<FrmPrincipal>();
            services.AddScoped<FrmImportarWallet>();
            services.AddScoped<FrmImportarDogecoinWallet>();
            services.AddScoped<FrmAdicionarCarteira>();

            var httpClientHandler = new HttpClientHandler
            {
                SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls,
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback = (sender, certificate, chain, erros) => {
                    var certhashString = certificate.GetCertHashString();
                    return true;
                    //if (development) return true;
                    //return erros == SslPolicyErrors.None && validCerts.Contains(certhashString);
                }
            };

            services.AddHttpClient<IDogecoinApiService, DogecoinApiService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Clear();
            }).ConfigurePrimaryHttpMessageHandler(x => httpClientHandler);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frmPrincipal = serviceProvider.GetRequiredService<FrmPrincipal>();
                System.Windows.Forms.Application.Run(frmPrincipal);
            }
        }// Ð

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<Random>();
            services.AddHttpClient();
        }
    }
}
