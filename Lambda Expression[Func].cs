using System;

namespace Lamda_Expression_Action_
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc =  (firstNumber,secondNumber) => firstNumber + secondNumber;
            
            Func<int, int, int> subtractFunc =  (firstNumber,secondNumber) =>firstNumber - secondNumber;
            
            Func<int, int, int> multiplicationFunc =( firstNumber, secondNumber)=>firstNumber * secondNumber;
            
            Func<int, int, int> divisionFunc = ( firstNumber,secondNumber)=>firstNumber / secondNumber;

            Calculator(addFunc, 10, 2);
            Calculator(subtractFunc, 10, 2);
            Calculator(multiplicationFunc, 10, 3);
            Calculator(divisionFunc, 10, 5);
        }

        static void Calculator(Func<int, int, int> operation, int firstNumber, int secondNumber)
        {
            Console.WriteLine(operation(firstNumber, secondNumber));
        }
    
    }
}
