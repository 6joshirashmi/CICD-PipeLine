using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController valuesController = new ValuesController();//arrange
    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void GetNum()
    {
        var x = valuesController.Get(1);//act
        Assert.Equal("Rashmi value", x);// assert
    }

}
