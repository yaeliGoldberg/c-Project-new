using System.IO;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal
{
    internal class ImplementationSale : Isale
    {



        
                //שורה ישנה
                //private static string path = "xml/sale.xml";
                private static string path = "../xml/sale.xml";

        //שורות ישנות
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Sale>));
                //private List<Sale> SaleList = (new XmlSerializer(typeof(List<Sale>))).Deserialize(new StreamReader(path)) as List<Sale>;

                //שורות חדשות עד אחרי הבנאי
                private List<Sale> SaleList;

                public ImplementationSale()
                {
                    if (File.Exists(path))
                    {
                        using StreamReader sr = new StreamReader(path);
                        SaleList = xmlSerializer.Deserialize(sr) as List<Sale>;
                    }
                    else
                    {
                        SaleList = new List<Sale>();
                    }
                }
        


        public int Create(Sale item)
        {
            int newId = Config.SaleNum;
            Sale newSale = item with { id = newId };

            using (StreamWriter writer = new StreamWriter(path))
            {

                SaleList.Add(newSale);
                xmlSerializer.Serialize(writer, SaleList);
            }
            return newId;
        }

        public void Delete(int id)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {

                Sale c = SaleList.Where(x => x.id == id).FirstOrDefault();
                if (c != null)
                    SaleList.Remove(c);
                xmlSerializer.Serialize(writer, SaleList);
            }
        }

        public Sale Read(int id)
        {
            return SaleList.Where(x => x.id == id).FirstOrDefault();
        }

        public Sale Read(Func<Sale, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter)
        {
            if (filter == null)
                return SaleList;
            return SaleList.Where(filter).ToList();
        }

        public void Update(Sale item)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                Sale sale = SaleList.Where(x => x.id == item.id).FirstOrDefault();
                if (sale != null)
                {
                    SaleList.Remove(sale);
                    SaleList.Add(item);
                }
                xmlSerializer.Serialize(writer, SaleList);
            }
        }
    }
}
