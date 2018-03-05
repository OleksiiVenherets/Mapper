namespace AutoMapperTests
{
    /// <summary>
    ///  Class to saving data about delievery information
    /// </summary>
    public class DelieveryInformation
    {
        public string Name { get; set; }
        public Order OrderInfo { get; set; }

        /// <summary>
        /// Parametrless constructor for class DelieveryInformation
        /// </summary>
        public DelieveryInformation()
        {
            OrderInfo = new Order() {Price = 0};
        }

        /// <summary>
        ///  Nested class to saving data about order
        /// </summary>
        public class Order
        {
            public decimal Price { get; set; }
            public DelieveryAdress DelieveryAdressInfo { get; set; }

            /// <summary>
            /// Parametrless constructor for class Order
            /// </summary>
            public Order()
            {
                DelieveryAdressInfo = new DelieveryAdress() {City = null, Street = null, HouseNumber = 0};
            }

            /// <summary>
            ///  Nested class to saving data about adress
            /// </summary>
            public class DelieveryAdress
            {
                public string City { get; set; }
                public string Street { get; set; }
                public int HouseNumber { get; set; }

                /// <summary>
                /// Parametrless constructor for class DelieveryAdress
                /// </summary>
                public DelieveryAdress () { }
            }
        }
    }
}
