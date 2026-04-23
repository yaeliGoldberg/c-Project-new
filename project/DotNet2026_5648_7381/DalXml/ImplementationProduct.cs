using System.IO;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal
{
    internal class ImplementationProduct : Iproducts
    {
        
        private static string path = "xml/products.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Products>));
        private List<Products> ProductsList = (new XmlSerializer(typeof(List<Products>))).Deserialize(new StreamReader(path)) as List<Products>;

        public int Create(Products item)
        {
            int newId = Config.ProductNum;
            Products newProduct = item with { id = newId };
           

            using (StreamWriter writer = new StreamWriter(path))
            {

                ProductsList.Add(newProduct);
                xmlSerializer.Serialize(writer, ProductsList);
            }
            return newId;
        }

        public void Delete(int id)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {

                Products p = ProductsList.Where(x => x.id == id).FirstOrDefault();
                if (p != null)
                    ProductsList.Remove(p);
                
                xmlSerializer.Serialize(writer, ProductsList);
            }
            
        }

        public Products Read(int id)
        {
            return ProductsList.Where(x => x.id == id).FirstOrDefault();         
        }

        public Products Read(Func<Products, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Products> ReadAll(Func<Products, bool>? filter = null)
        {
            if (filter == null)
                return ProductsList;
            return ProductsList.Where(filter).ToList();
        }

        public void Update(Products item)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                Products sale = ProductsList.Where(x => x.id == item.id).FirstOrDefault();
                if (sale != null)
                {
                    ProductsList.Remove(sale);
                    ProductsList.Add(item);
                }
                xmlSerializer.Serialize(writer, ProductsList);
            }
        }
    }
}
