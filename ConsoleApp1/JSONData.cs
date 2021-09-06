using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class JSONData
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Picture
        {
            public string url { get; set; }
        }

        public class Feature
        {
            public int cloudId { get; set; }
            public string displayName { get; set; }
            public string value { get; set; }
            public string productId { get; set; }
            public string gtin { get; set; }
            public bool isProductChanger { get; set; }
            public bool isInStock { get; set; }
            public int order { get; set; }
            public Picture picture { get; set; }
        }

        public class Selected
        {
            public int cloudId { get; set; }
            public string displayName { get; set; }
            public string value { get; set; }
            public string productId { get; set; }
            public string gtin { get; set; }
            public bool isProductChanger { get; set; }
            public bool isInStock { get; set; }
            public int order { get; set; }
            public Picture picture { get; set; }
        }

        public class Variant
        {
            public int cloudId { get; set; }
            public string groupName { get; set; }
            public string groupId { get; set; }
            public List<Feature> features { get; set; }
            public int order { get; set; }
            public Selected selected { get; set; }
        }

        public class Filter
        {
            public string filterItemId { get; set; }
        }

        public class Picture4
        {
            public string url { get; set; }
            public int? order { get; set; }
        }

        public class Category
        {
            public string id { get; set; }
            public string name { get; set; }
            public bool isRoot { get; set; }
            public string parentCategoryId { get; set; }
            public string description { get; set; }
            public int order { get; set; }
            public bool IncludeInTopMenu { get; set; }
        }

        public class Root
        {
            public string id { get; set; }
            public int cloudId { get; set; }
            public string itemId { get; set; }
            public string productName { get; set; }
            public string headline { get; set; }
            public string gtin { get; set; }
            public bool inStock { get; set; }
            public List<Variant> variants { get; set; }
            public List<Filter> filters { get; set; }
            public Picture picture { get; set; }
            public List<Picture> pictures { get; set; }
            public string productDetailUrl { get; set; }
            public List<object> reviews { get; set; }
            public int quantity { get; set; }
            public Category category { get; set; }
            public string sku { get; set; }
            public string ProductUrl { get; set; }
        }


    }
}
