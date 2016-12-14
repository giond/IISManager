namespace IISManager.Managers
{
    public class ConfigurationManager
    {
        public static string ApiKey
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["key"];
            }
        }

        public static string Token
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["token"];
            }
        }

        public static int TimeoutInSecconds
        {
            get
            {
                return int.Parse(System.Configuration.ConfigurationManager.AppSettings["timeout_in_secconds"]);
            }
        }
    }
}