using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Ecom_v01
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "Abvuiy3PbHVFcTqmiHd76dmw-qkFHLNdWkg9L_nRJx8LYgQgRvKQhuDbZMiatgxTM092RGIUk3lXOGRZ";
            clientSecret = "EDyv8mkIsb5Qr1unXa-OvSxVwIATKtNKMZXMRYnAzHODafc1yXz_hbMgrOOpp8mzCc1CP1HlZhe1_G3_";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}