/*using System.Xml.Linq;

namespace Dal;

static internal class Config
{
    private const string NameFile = "data-config";

    public static int ProductNum
    {
        get
        {
            XElement root = XElement.Load($"xml/{NameFile}.xml");

            int current = int.Parse(root.Element("ProductNum").Value);

            root.Element("ProductNum").Value = (current + 1).ToString();

            root.Save($"xml/{NameFile}.xml");

            return current;
        }
    }

    public static int SaleNum
    {
        get
        {

            XElement root = XElement.Load($"xml/{NameFile}.xml");

            int current = int.Parse(root.Element("SaleNum").Value);

            root.Element("SaleNum").Value = (current + 1).ToString();

            root.Save($"xml/{NameFile}.xml");

            return current;
        }
    }

    public static int CustomerNum
    {
        get
        {
            XElement root = XElement.Load($"xml/{NameFile}.xml");

            int current = int.Parse(root.Element("CustomerNum").Value);

            root.Element("CustomerNum").Value = (current + 1).ToString();

            root.Save($"xml/{NameFile}.xml");

            return current;
        }
    }

}

*/
/*using System.Xml.Linq;

namespace Dal;

internal static class Config
{

    private static string fileName = "../xml/data-config.xml";
    private static XElement dataConfig = XElement.Load(fileName);

    private static int productId;

    public static int ProductNum
    {
        get
        {
            int currentProId = int.Parse(dataConfig.Element("ProductNum").Value);
            dataConfig.Element("ProductNum").SetValue((currentProId + 1).ToString());
            dataConfig.Save(fileName);
            return currentProId;
        }
    }


    private static int saleId;

    public static int SaleNum
    {
        get
        {
            int currentSaleId = int.Parse(dataConfig.Element("SaleNum").Value);
            dataConfig.Element("SaleNum").SetValue((currentSaleId + 1).ToString());
            dataConfig.Save(fileName);
            return currentSaleId;
        }


    }
    public static int CustomerNum
    {
        get
        {
            int currentSaleId = int.Parse(dataConfig.Element("CustomerNum").Value);
            dataConfig.Element("CustomerNum").SetValue((currentSaleId + 1).ToString());
            dataConfig.Save(fileName);
            return currentSaleId;
        }


    }
}*/

using System;
using System.IO;
using System.Xml.Linq;

namespace Dal
{
    internal static class Config
    {
        private static string fileName = Path.Combine("xml", "data-config.xml");

        private static XElement LoadConfig()
        {
            if (!File.Exists(fileName))
            {
                XElement newConfig = new XElement("Config",
                    new XElement("ProductNum", 0),
                    new XElement("SaleNum", 0),
                    new XElement("CustomerNum", 0)
                );

                Directory.CreateDirectory("xml");
                newConfig.Save(fileName);
            }

            return XElement.Load(fileName);
        }

        public static int ProductNum
        {
            get
            {
                XElement dataConfig = LoadConfig();

                XElement element = dataConfig.Element("ProductNum");
                if (element == null)
                    throw new Exception("Missing ProductNum in config XML");

                int current = int.Parse(element.Value);

                element.Value = (current + 1).ToString();
                dataConfig.Save(fileName);

                return current;
            }
        }

        public static int SaleNum
        {
            get
            {
                XElement dataConfig = LoadConfig();

                XElement element = dataConfig.Element("SaleNum");
                if (element == null)
                    throw new Exception("Missing SaleNum in config XML");

                int current = int.Parse(element.Value);

                element.Value = (current + 1).ToString();
                dataConfig.Save(fileName);

                return current;
            }
        }

        public static int CustomerNum
        {
            get
            {
                XElement dataConfig = LoadConfig();

                XElement element = dataConfig.Element("CustomerNum");
                if (element == null)
                    throw new Exception("Missing CustomerNum in config XML");

                int current = int.Parse(element.Value);

                element.Value = (current + 1).ToString();
                dataConfig.Save(fileName);

                return current;
            }
        }
    }
}