using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //get();
            Create();
            Console.ReadLine();
        }

        public static void get()
        {
            var client = new RestClient("https://dev.shopiconnect.com/api/product/");
            var request = new RestRequest("123");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                JSONData result = JsonConvert.DeserializeObject<JSONData>(rawResponse);
            }

        }

        public static void Create()
        {
            var client = new RestClient("https://dev.shopiconnect.com/api/productImport/");
            var request = new RestRequest("create",Method.POST);
            
            request.AddParameter("IntegrationId","Test");
            request.AddParameter("BaseProductCode", "Test");
            request.AddParameter("ColorVariantCode", "Test");
            request.AddParameter("Sku", "Test");
            request.AddParameter("StockAmount", "Test");
            request.AddParameter("Ean", "Test");
            request.AddParameter("TaxRate", "Test"); 
            request.AddParameter("Size", "Test");
            request.AddParameter("Title", "Test");
            request.AddParameter("Headline", "Test");
            request.AddParameter("Description", "Test");
            request.AddParameter("MainCategory", "Test");
            request.AddParameter("FirstSellingVat", "Test");
            request.AddParameter("LastSellingVat", "Test");
            request.AddParameter("Color", "Test");
            request.AddParameter("Image1Link", "Test");
            request.AddParameter("Image2Link", "Test");
            request.AddParameter("Image3Link", "Test");
            request.AddParameter("Image4Link", "Test");
            request.AddParameter("Image5Link", "Test");
            request.AddParameter("WebCategory", "Test");
            request.AddParameter("Store", "Test");
            request.AddParameter("IsDeleted", "Test");
            request.AddParameter("IsUnpublished", "Test");
            request.AddParameter("Variant3", "Test");
            request.AddParameter("Variant4", "Test");
            request.AddParameter("Filter3", "Test");
            request.AddParameter("Filter4", "Test");
            request.AddParameter("Filter5", "Test");
            request.AddParameter("Filter6", "Test");
            request.AddHeader("Content-Type", "application/json;charset=utf-8");

            var response = client.Execute(request);
            foreach (var item in response.Content)
            {
                Console.WriteLine(item);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
              
            }
        }
    }
}
