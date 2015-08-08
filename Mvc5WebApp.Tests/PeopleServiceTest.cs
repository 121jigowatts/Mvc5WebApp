using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc5WebApp.ServiceImplementations;
using Moq;
using Mvc5WebApp.RepositoryInterfaces;
using Mvc5WebApp.Contracts;

namespace Mvc5WebApp.Tests
{
    /// <summary>
    /// Summary description for PeopleServiceTest
    /// </summary>
    [TestClass]
    public class PeopleServiceTest
    {
        public PeopleServiceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetTest()
        {

            var repository = new Mock<IPeopleRepository>();
            repository.Setup(r => r.Get());
            var mapper = new Mock<IObjectMapper>();
            mapper.Setup(m => m.Map<Models.Person>(It.IsAny<Mvc5WebApp.SQLServerRepositories.Database.Person>()));

            var service = new PeopleService(repository.Object, mapper.Object);

        }
    }
}
