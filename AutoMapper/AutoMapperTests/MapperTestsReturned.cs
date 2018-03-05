using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

namespace AutoMapperTests
{
    /// <summary>
    /// Test class. Contains tests which verificate correct application work without nested classes
    /// </summary>
    [TestClass]
    public class MapperTestsReturned
    {
        /// <summary>
        /// Test method to verificate mapping sourse object to new object Generic type
        /// </summary>
        [TestMethod]
        public void MapUserToNewPersonReturned()
        {
            var registerModel = new RegisterModel { Id = 1, Name = "Ivan", Email = "Ivan@gmail.com", Login = "IvanIvan", Password = "12345" };

            var registerToLoginExpected = new LoginModel { Id = 1, Login = "IvanIvan", Password = "12345" };

            var mapper = new Mapper();
            var registerToLoginActual = mapper.Map<RegisterModel, LoginModel>(registerModel);

            Assert.IsTrue(registerToLoginExpected.Id == registerToLoginActual.Id && registerToLoginExpected.Login == registerToLoginActual.Login
                         && registerToLoginExpected.Password == registerToLoginActual.Password);
        }

        /// <summary>
        /// Test method to verificate mapping sourse object to destination object
        /// </summary>
        [TestMethod]
        public void MapUserToExistingUserReturned()
        {
            var registerModel = new RegisterModel { Id = 1, Name = "Ivan", Email = "Ivan@gmail.com", Login = "IvanIvan", Password = "12345" };
            var loginModel = new LoginModel() {Id = 1, Login = "qwe", Password = "123"};
            var registerToLoginExpected = new LoginModel { Id = 1, Login = "IvanIvan", Password = "12345" };

            var mapper = new Mapper();
            var registerToLoginActual = mapper.Map(registerModel, loginModel);

            Assert.IsTrue(registerToLoginExpected.Id == registerToLoginActual.Id && registerToLoginExpected.Login == registerToLoginActual.Login
             && registerToLoginExpected.Password == registerToLoginActual.Password);
        }
    }
}
