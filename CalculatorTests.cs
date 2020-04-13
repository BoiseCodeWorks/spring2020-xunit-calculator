using Xunit;

public class CalculatorTests
{

  [Fact]
  public void Can_Add_Five_And_Ten_And_Get_Back_Fifteen()
  {
    Calculator calculator = new Calculator();
    Assert.Equal(15, calculator.Add(5, 10));
  }

  [Fact]
  public void Can_Add_Ten_And_Five_And_Get_Back_Fifteen()
  {
    Calculator calculator = new Calculator();
    Assert.Equal(15, calculator.Add(10, 5));
  }

  [Fact]
  public void Can_Add_Five_And_Nine_And_Get_Back_Fourteen()
  {
    //Given
    int firstNum = 5;
    int secondNum = 9;
    int expected = 14;
    Calculator calculator = new Calculator();
    //When
    int actual = calculator.Add(firstNum, secondNum);
    //Then
    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData(10, 5, 15)]
  [InlineData(5, 10, 15)]
  [InlineData(5, 9, 14)]
  public void Can_Add_Two_Numbers_Together(int num1, int num2, int expected)
  {

    Calculator calculator = new Calculator();
    int actual = calculator.Add(num1, num2);

    Assert.Equal(expected, actual);
  }

}