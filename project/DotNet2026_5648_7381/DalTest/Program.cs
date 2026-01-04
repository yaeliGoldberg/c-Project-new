using DalApi;
using DO;
using Dal;


namespace DalTest
{
    public class Program
    {
        private static IDal s_dal = new DalList(); // השדה הסטטי לשימוש בכל הפונקציות

        public static void Main(string[] args)
        {
            try
            {
                Initialization.Initialize(s_dal);
            }
            catch (NotExistException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AlreadyExistException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int num1 = 0;
            try
            {
                do
                {
                    Console.WriteLine("insert 1 to customers, 2 to products, 3 to sales, 4 to exit");
                    num1 = int.Parse(Console.ReadLine());
                    switch (num1)
                    {
                        case 1: customersUser(); break;
                        case 2: productsUser(); break;
                        case 3: salesUser(); break;
                        case 4: break;
                        default: Console.WriteLine("illegal num"); break;
                    }
                } while (num1 != 4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // =================== פונקציות משתמש ===================
        private static void customersUser()
        {
            int menuNum = menuCrud();
            var c = s_dal.Customer;

            switch (menuNum)
            {
                case 1:
                    c.Create(getUserCustomer());
                    break;
                case 2:
                    ReadAll(c);
                    break;
                case 3:
                    Read(c, getId());
                    break;
                case 4:
                    c.Update(getUserCustomer(getId()));
                    break;
                case 5:
                    Delete(c, getId());
                    break;
                default:
                    Console.WriteLine("illegal number");
                    break;
            }
        }

        private static void productsUser()
        {
            int menuNum = menuCrud();
            var p = s_dal.Products;

            switch (menuNum)
            {
                case 1:
                    p.Create(getUserProduct());
                    break;
                case 2:
                    ReadAll(p);
                    break;
                case 3:
                    Read(p, getId());
                    break;
                case 4:
                    p.Update(getUserProduct(getId()));
                    break;
                case 5:
                    Delete(p, getId());
                    break;
                default:
                    Console.WriteLine("illegal number");
                    break;
            }
        }

        private static void salesUser()
        {
            int menuNum = menuCrud();
            var s = s_dal.Sale;

            switch (menuNum)
            {
                case 1:
                    s.Create(getUserSale());
                    break;
                case 2:
                    ReadAll(s);
                    break;
                case 3:
                    Read(s, getId());
                    break;
                case 4:
                    s.Update(getUserSale(getId()));
                    break;
                case 5:
                    Delete(s, getId());
                    break;
                default:
                    Console.WriteLine("illegal number");
                    break;
            }
        }

        // =================== פונקציות CRUD גנריות ===================
        private static void ReadAll<T>(Icrud<T> repo)
        {
            List<T> items = repo.ReadAll();
            foreach (var i in items)
                Console.WriteLine(i);
        }

        private static void Read<T>(Icrud<T> repo, int id)
        {
            Console.WriteLine(repo.Read(id));
        }

        private static void Delete<T>(Icrud<T> repo, int id)
        {
            repo.Delete(id);
        }

        // =================== פונקציות עזר ===================
        private static int menuCrud()
        {
            Console.WriteLine("insert 1 to create, 2 to read all, 3 to read, 4 to update, 5 to delete");
            return int.Parse(Console.ReadLine());
        }

        private static int getId()
        {
            Console.WriteLine("insert id");
            return int.Parse(Console.ReadLine());
        }

        private static Customer getUserCustomer(int id = 0)
        {
            Console.WriteLine("insert name, address, phone");
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone = Console.ReadLine();

            return new Customer() { id = id, name = name, adress = address, phon = phone };
        }

        private static Products getUserProduct(int id = 0)
        {
            Console.WriteLine("insert name, category - 1 for Chocolate and so on..., price, quantity");
            string name = Console.ReadLine();
            int category = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());

            return new Products() { id = id, name = name, c = (Categories)category, price = price, amount = quantity };
        }

        private static Sale getUserSale(int id = 0)
        {
            Console.WriteLine("insert productId, quantityRequired, totalPrice, isOnlyClub, startSale, endSale. Date format: 12/12/1090");
            int productId = int.Parse(Console.ReadLine());
            int quantityRequired = int.Parse(Console.ReadLine());
            double totalPrice = double.Parse(Console.ReadLine());
            bool isOnlyClub = bool.Parse(Console.ReadLine());
            DateTime startSale = DateTime.Parse(Console.ReadLine());
            DateTime endSale = DateTime.Parse(Console.ReadLine());

            return new Sale()
            {
                id = id,
                id_product = productId,
                min_amount = quantityRequired,
                min_price = totalPrice,
                for_who = isOnlyClub,
                start_sale = startSale,
                end_sale = endSale
            };
        }
    }
}
