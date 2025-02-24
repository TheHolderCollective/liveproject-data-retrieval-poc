using Gtc.Services;

namespace Gtc.Models.FederalRegister
{
    public class Gtc
    {
        public static void Main(string[] args)
        {
            string urlEndPoint = "https://www.federalregister.gov/api/v1/documents.json?conditions[publication_date][year]=2023&conditions[agencies][]=agriculture-department";
            var federalRegisterService = new FederalRegisterService();

            try
            {
                var response = federalRegisterService.GetResponseAsync(urlEndPoint);
                Console.WriteLine(response.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}