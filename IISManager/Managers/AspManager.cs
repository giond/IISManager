using IISManager.Exceptions;
using IISManager.DiscountAspServiceClient;
using System.Threading.Tasks;

namespace IISManager.Managers
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

        public static void Recycle()
        {
            var client = new CustomerApiSoapClient("CustomerApiSoap");

            CheckApiKey(client);

            //client.IisRecycleApplicationPool(ConfigurationManager.ApiKey);
        }

        public static void Stop()
        {
            var client = new CustomerApiSoapClient("CustomerApiSoap");

            CheckApiKey(client);

            //client.IisStopSite(ConfigurationManager.ApiKey);
        }

        public static void Start()
        {
            var client = new CustomerApiSoapClient("CustomerApiSoap");

            CheckApiKey(client);

            //client.IisStartSite(ConfigurationManager.ApiKey);
        }

        public static async Task Restart()
        {
            var client = new CustomerApiSoapClient("CustomerApiSoap");

            CheckApiKey(client);

            await Task.Run(async () =>
            {
                //client.IisStopSite(ConfigurationManager.ApiKey);

                await Task.Delay(ConfigurationManager.TimeoutInSecconds * 1000);

                //client.IisStartSite(ConfigurationManager.ApiKey);
            });
        }
    }
}