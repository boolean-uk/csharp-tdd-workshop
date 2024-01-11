using workshop.main;

namespace workshop.tests;

[TestFixture]
public class Tests
{

    
    [SetUp]
    public void Setup()
    {
       
    }
    

    [Test]
    public void AddTwoNumbers()
    {
        //arrange 
        Calculator calculator = new Calculator();
        //act
        int result = calculator.Add(1, 2);

        //assert
        Assert.That(result, Is.EqualTo(3));
        
    }


    [TestCase(1,2,3)]
    [TestCase(2, 2, 4)]
    public void AddTwoNumbersTestCase(int firstNumber, int secondNumber, int actual)
    {
        //arrange 
        Calculator calculator = new Calculator();

        //act
        int result = calculator.Add(firstNumber, secondNumber);
       
        //assert
        Assert.That(result, Is.EqualTo(actual));

    }
   
}