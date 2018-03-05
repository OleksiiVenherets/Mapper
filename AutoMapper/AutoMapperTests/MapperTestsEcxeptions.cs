using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

namespace AutoMapperTests
{
    /// <summary>
    /// Test class. Contains tests which verificate throwing exceptions
    /// </summary>
    [TestClass]
    public class MapperTestsEcxeptions
    {
        /// <summary>
        /// Test method to verificate throwing exceprion when sourse object is not instanced 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ObjectNullException))]
        public void MapUserToNewPersonNullExceptions ()
        {
            var mapper = new Mapper();
            var mappedObject = mapper.Map<User, Person>(null);
        }

        /// <summary>
        /// Test method to verificate throwing exceprion when sourse object is not instanced 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ObjectNullException))]
        public void MapUserNullToExistingPersonExceptions()
        {
            var person = new Person();
            var mapper = new Mapper();
            var mappedObject = mapper.Map<User, Person>(null, person);
        }

        /// <summary>
        /// Test method to verificate throwing exceprion when destination object is not instanced 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ObjectNullException))]
        public void MapUserToExistingPersonNullExceptions()
        {
            var user = new User { Age = 20, Name = "Oleksii", Logs = new User.Log { Login = "qwe", Pass = "123" } };
            var mapper = new Mapper();
            var mappedObject = mapper.Map<User, Person>(user, null);
        }

        /// <summary>
        /// Test method to verificate throwing exceprion when properties of sourse object are not initialize
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyObjectException))]
        public void MapUserToNewPersonEmptyExceptions()
        {
            var user = new User();
            var mapper = new Mapper();
            var mappedObject = mapper.Map<User, Person>(user);
        }

        /// <summary>
        /// Test method to verificate throwing exceprion when properties of sourse object are not initialize
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyObjectException))]
        public void MapUserToExistingPersonEmptyExceptions()
        {
            var user = new User();
            var person = new Person();
            var mapper = new Mapper();
            var mappedObject = mapper.Map<User, Person>(user, person);
        }

    }
}
