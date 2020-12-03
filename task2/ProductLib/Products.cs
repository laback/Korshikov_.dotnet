using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProductLib
{
    public class Products
    {
        public List<Product> FileRead(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            List<Product> products;
            string str = streamReader.ReadLine();
            products = JsonConvert.DeserializeObject<List<Product>>(str);
            return products;
        }
        public void FileWrite(List<Product> products, string path)
        {
            File.AppendAllText(path, JsonConvert.SerializeObject(products));
        }
    }
}
