
using DalApi;
using DO;
using System.Xml.Linq;

namespace Dal;

internal class ImplementationCustomer : Icoustomer
{
    string path = "xml/customers.xml";
    public int Create(Customer customer)
    {
        
        XElement root = XElement.Load(path);
        int newId = Config.CustomerNum;
        Customer newCustomer = customer with { id = newId };
        XElement customerElement = new XElement("Customer",
            new XElement("Id", newCustomer.id),
            new XElement("Name", newCustomer.name),
            new XElement("Adress", newCustomer.adress),
            new XElement("Phon", newCustomer.phon)
        );
        root.Add(customerElement);
        root.Save(path);
        return newId;

    }
    public Customer? Read(int id)
    {
   
        XElement root = XElement.Load(path);

       
        XElement? customerElement = root.Elements("Customer")
            .FirstOrDefault(c => (int)c.Element("Id") == id);
        if(customerElement == null) {
            return null;
        }
        Customer customer = new Customer(
       id: (int)customerElement.Element("Id"),
       name: (string)customerElement.Element("Name"),
       adress: (string)customerElement.Element("Adress"),
       phon: (string)customerElement.Element("Phon")
                                                           );
            return customer;
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        XElement root = XElement.Load(path);

        List<Customer> customers = root.Elements("Customer")
            .Select(c => new Customer(
                id: (int)c.Element("Id"),
                name: (string)c.Element("Name"),
                adress: (string)c.Element("Adress"),
                phon: (string)c.Element("Phon")
            ))
            .ToList();

       
        if (filter == null)
            return customers.Cast<Customer?>().ToList();

       
        return customers.Where(filter).Cast<Customer?>().ToList();
    }
    public void Update(Customer item)
    {
        XElement root = XElement.Load(path);

        // מציאת הלקוח לפי ID
        XElement? customerElement = root.Elements("Customer")
            .FirstOrDefault(c => (int)c.Element("Id") == item.id);
        if (customerElement == null) return;

        // עדכון השדות
        customerElement.Element("Name")?.SetValue(item.name);
        customerElement.Element("Adress")?.SetValue(item.adress);
        customerElement.Element("Phon")?.SetValue(item.phon);
        root.Save(path);
    }
    public void Delete(Customer item)
    {
        XElement root = XElement.Load(path);

        XElement? customerElement = root.Elements("Customer")
            .FirstOrDefault(c => (int)c.Element("Id") == item.id);
        if (customerElement == null) return;

        // הסרת הלקוח
        customerElement.Remove();
        root.Save(path);
    }
    }
