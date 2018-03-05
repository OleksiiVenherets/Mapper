using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

namespace AutoMapperTests
{
    /// <summary>
    /// Test class. Contains tests which verificate correct application work with nested classes
    /// </summary>
    [TestClass]
    public class MapperTestsWithTwoNestedClassesReturned
    {
        /// <summary>
        /// Test method to verificate mapping sourse object to new object Generic type
        /// </summary>
        [TestMethod]
        public void MapCustomerToNewDelieveryInformationReturned()
        {
            var customer = new Customer
            {
                Id = 1,
                Name = "Ivan",
                OrderInfo = new Customer.Order
                {
                    OrderNumber = 1,
                    Price = 100,
                    DelieveryAdressInfo =
                        new Customer.Order.DelieveryAdress{City = "Lviv", Street = "Bandery", HouseNumber = 28}
                }
            };

            var customerToDelieveryExpected = new DelieveryInformation
            {
                Name = "Ivan",
                OrderInfo = new DelieveryInformation.Order
                {
                    Price = 100,
                    DelieveryAdressInfo =
                        new DelieveryInformation.Order.DelieveryAdress
                        {
                            City = "Lviv",
                            Street = "Bandery",
                            HouseNumber = 28
                        }
                }
            };

            var mapper = new Mapper();
            var customerToDelieveryActual = mapper.Map<Customer, DelieveryInformation>(customer);
            
            Assert.IsTrue(customerToDelieveryExpected.Name == customerToDelieveryActual.Name &&
                          customerToDelieveryExpected.OrderInfo.Price == customerToDelieveryActual.OrderInfo.Price &&
                          customerToDelieveryExpected.OrderInfo.DelieveryAdressInfo.City == customerToDelieveryActual.OrderInfo.DelieveryAdressInfo.City &&
                          customerToDelieveryExpected.OrderInfo.DelieveryAdressInfo.Street == customerToDelieveryActual.OrderInfo.DelieveryAdressInfo.Street &&
                          customerToDelieveryExpected.OrderInfo.DelieveryAdressInfo.HouseNumber == customerToDelieveryActual.OrderInfo.DelieveryAdressInfo.HouseNumber);
        }

        /// <summary>
        /// Test method to verificate mapping sourse object to destination object
        /// </summary>
        [TestMethod]
        public void MapCustomerToExistingDelieveryInformationReturned()
        {
            var customer = new Customer
            {
                Id = 1,
                Name = "Ivan",
                OrderInfo = new Customer.Order
                {
                    OrderNumber = 1,
                    Price = 100,
                    DelieveryAdressInfo =
                        new Customer.Order.DelieveryAdress { City = "Lviv", Street = "Bandery", HouseNumber = 28 }
                }
            };

            var delieveryInformation = new DelieveryInformation();
            var customerToDelieveryExpected = new DelieveryInformation
            {
                Name = "Ivan",
                OrderInfo = new DelieveryInformation.Order
                {
                    Price = 100,
                    DelieveryAdressInfo =
                        new DelieveryInformation.Order.DelieveryAdress
                        {
                            City = "Lviv",
                            Street = "Bandery",
                            HouseNumber = 28
                        }
                }
            };

            var mapper = new Mapper();
            var customerToDelieveryActual = mapper.Map(customer, delieveryInformation);

            Assert.IsTrue(customerToDelieveryExpected.Name == customerToDelieveryActual.Name &&
                          customerToDelieveryExpected.OrderInfo.Price == customerToDelieveryActual.OrderInfo.Price &&
                          customerToDelieveryExpected.OrderInfo.DelieveryAdressInfo.City == customerToDelieveryActual.OrderInfo.DelieveryAdressInfo.City &&
                          customerToDelieveryExpected.OrderInfo.DelieveryAdressInfo.Street == customerToDelieveryActual.OrderInfo.DelieveryAdressInfo.Street &&
                          customerToDelieveryExpected.OrderInfo.DelieveryAdressInfo.HouseNumber == customerToDelieveryActual.OrderInfo.DelieveryAdressInfo.HouseNumber);
          }
    }
}
