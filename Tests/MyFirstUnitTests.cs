using Xunit;
using BlazorServerAPI.Pages;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using BlazorServerAPI.Helpers;



namespace BlazorServerAPI.Tests
{
    public class MyFirstUnitTests
    {
        public int summa;
        public string activityData;
        /*
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
        */
       /*[Fact]
        public void CompareTest()
        {
        //summa = BlazorServerAPI.Helpers.testValue.returnSum(1, 1);
        //Assert.Equal(summa, 1);

        testValue _testValue = new testValue();
        summa = _testValue.returnSum(1, 1);
        Assert.Equal(summa, 2);
        }*/
        [Fact]
        public void ApiTest(){
            
            Assert.NotNull(ApiResponseTest.PrintWebApiResponse());
            
        }
    }
}
