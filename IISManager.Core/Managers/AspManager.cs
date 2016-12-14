using System.Threading.Tasks;
using IISManager.Core.DiscountAspServiceClient;
using IISManager.Core.Exceptions;

namespace IISManager.Core.Managers
{
    public class AspManager
    {
        private static void CheckApiKey(CustomerApiSoapClient client)
        {
            if (!client.VerifyKey(ConfigurationManager.ApiKey))
            {
                throw new BusinessException("API key is not verified.");
            }
        }

        public static async Task Recycle()
        {
            await Task.Run(async () =>
            {
                var client = new CustomerApiSoapClient("CustomerApiSoap");

                CheckApiKey(client);

                //await client.IisRecycleApplicationPoolAsync(ConfigurationManager.ApiKey);
            });
        }

        public static async Task Stop()
        {
            await Task.Run(async () =>
            {
                var client = new CustomerApiSoapClient("CustomerApiSoap");

                CheckApiKey(client);

                //client.IisStopSite(ConfigurationManager.ApiKey);
            });
        }

        public static async Task Start()
        {
            await Task.Run(async () =>
            {
                var client = new CustomerApiSoapClient("CustomerApiSoap");

                CheckApiKey(client);

                //client.IisStartSite(ConfigurationManager.ApiKey);
            });
        }

        public static async Task Restart()
        {
            await Task.Run(async () =>
            {
                var client = new CustomerApiSoapClient("CustomerApiSoap");

                CheckApiKey(client);


                //client.IisStopSite(ConfigurationManager.ApiKey);

                await Task.Delay(ConfigurationManager.TimeoutInSecconds * 1000);

                //client.IisStartSite(ConfigurationManager.ApiKey);
            });
        }
    }
}
