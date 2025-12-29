namespace Dal
{
   internal static class DataSource
    {

        internal static List<Product?> Products = new List<Product>();
        internal static List<Customer?> Customers = new List<Customer>();
        internal static List<Sale?> Sales = new List<Sale>();
    }

    internal static class Config
    {
        internal const int minimum = 1000;
        private static int value_static = minimum;
        public static int run_value_static { get { return value_static++; } }
    }
}

