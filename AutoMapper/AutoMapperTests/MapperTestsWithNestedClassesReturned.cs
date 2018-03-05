using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

namespace AutoMapperTests
{
    /// <summary>
    /// Test class. Contains tests which verificate correct application work with one nested class
    /// </summary>
    [TestClass]
    public class MapperTestsWithNestedClassesReturned
    {
        /// <summary>
        /// Test method to verificate mapping sourse object to new object Generic type
        /// </summary>
        [TestMethod]
        public void MapUserToNewPersonReturned()
        {
            var user = new User {Age = 20, Name = "Oleksii", Logs = new User.Log {Login = "qwe", Pass="123"} };

            var userToPesonExpected = new Person {Age = 20, Name = "Oleksii", Logs = new Person.Log {Login="qwe"} };
            var mapper = new Mapper();
            var userToPesonActual = mapper.Map<User, Person>(user);


            Assert.IsTrue(userToPesonExpected.Age == userToPesonActual.Age && userToPesonExpected.Name == userToPesonActual.Name 
                && userToPesonExpected.Logs.Login == userToPesonActual.Logs.Login);
        }

        /// <summary>
        /// Test method to verificate mapping sourse object to destination object
        /// </summary>
        [TestMethod]
        public void MapUserToExistingUserReturned()
        {
            var user = new User { Age = 20, Name = "Oleksii", Logs = new User.Log { Login = "qwe", Pass = "123" } };
            var person = new Person();

            
            var userToPesonExpected = new Person { Age = 20, Name = "Oleksii", Logs = new Person.Log { Login = "qwe" } };
            var mapper = new Mapper();
            var userToPesonActual = mapper.Map(user, person);
            Assert.IsTrue(userToPesonExpected.Age == userToPesonActual.Age && userToPesonExpected.Name == userToPesonActual.Name
                && userToPesonExpected.Logs.Login == userToPesonActual.Logs.Login);
        }
    }  
}
