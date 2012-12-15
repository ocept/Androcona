using Androcona;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Androcona.Test
{
    
    
    /// <summary>
    ///This is a test class for AlarmTest and is intended
    ///to contain all AlarmTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AlarmTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Alarm Constructor
        ///</summary>
        [TestMethod()]
        public void AlarmConstructorTest()
        {
            AlarmSettings settings = new AlarmSettings();
            System.DateTime testDate = System.DateTime.Now.AddHours(1);
            settings.time = testDate;
            settings.type = AlarmSettings.aType.Alarm;
            Alarm target = new Alarm(settings);
            Assert.IsNotNull(target);
            Assert.AreEqual(AlarmSettings.aType.Alarm, target.AlarmType);
            Assert.AreEqual(testDate, target.AlarmTime);


        }
    }
}
