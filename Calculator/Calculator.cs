namespace Cucumber
{
    public class Calculator
    {

        private int _firstNumber;
        private int _secondNumber;
        private int _result;

        public void SetFirstNumber(int fistNumber)
        {
            _firstNumber = fistNumber;
        }

        public void SetSecondNumber(int secondNumber)
        {
            _secondNumber = secondNumber;
        }

        public void AddNumbers()
        {
            _result = _firstNumber + _secondNumber;
        } 
        
        public void MultiplyNumbers()
        {
            _result = _firstNumber * _secondNumber;
        }

        public int GetResult()
        {
            return _result;
        }

    }
}
