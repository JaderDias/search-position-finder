using SearchPositionFinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SearchPositionFinderTest
{
    
    
    /// <summary>
    ///This is a test class for FinderTest and is intended
    ///to contain all FinderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FinderTest
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
        ///A test for GetPosition
        ///</summary>
        [TestMethod()]
        public void GetPositionTest()
        {
            var searchUriFormat = "http://www.google.com.br/search?q=search+position+finder&start={0}0";
            var siteUri = "http://code.google.com/p/search-position-finder";
            int expected = 0;
            var actual = Finder.GetPosition(searchUriFormat, siteUri);
            Assert.AreEqual(expected, actual);
        }
    }
}
