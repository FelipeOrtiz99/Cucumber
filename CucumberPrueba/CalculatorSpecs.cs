using Cucumber;
using Xunit;
using Xunit.Gherkin.Quick;

namespace CucumberPrueba
{
    [FeatureFile(@"./CalculatorSpecs.feature")]
    public sealed class CalculatorSpecs : Feature
    {

    private readonly Calculator _calculator = new Calculator();

    [Given(@"I have (\d+) as the first number")]
    public void Given_I_have_first_number(int firstNumber)
    {
        _calculator.SetFirstNumber(firstNumber);
    }

    [And(@"I have (\d+) as the second number")]
    public void And_I_have_second_number(int secondNumber)
    {
        _calculator.SetSecondNumber(secondNumber);
    }

    [When(@"I ask to add up these numbers")]
    public void When_I_ask_to_add()
    {
       _calculator.AddNumbers();
    }

    [When(@"I ask to multiply these numbers")]
    public void When_I_ask_to_multiply()
        {
            _calculator.MultiplyNumbers();
        }


    [Then(@"I receive (\d+) as a result")]
    public void Then_I_receive_result(int result)
    {
        int actualResult = _calculator.GetResult();
        Assert.Equal(result, actualResult);

    }

    }
}