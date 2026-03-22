using System.Xml.Linq;

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