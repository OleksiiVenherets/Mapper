namespace AutoMapperTests
{
    /// <summary>
    /// Class to saving data about customer
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Order OrderInfo { get; set; }

        /// <summary>
        /// Nested class to saving data about order
        /// </summary>
        public class Order
        {
            public int OrderNumber { get; set; }
            public decimal Price { get; set; }
            public DelieveryAdress DelieveryAdressInfo { get; set; }

            /// <summary>
            /// Nested class to saving data about adress
            /// </summary>
            public class DelieveryAdress
            {
                public string City { get; set; }
                public string Street { get; set; }
                public int HouseNumber { get; set; }
            }
        }
    }
}
