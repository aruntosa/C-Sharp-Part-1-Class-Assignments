using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3A
{
    class MathOperation
    {
        int firstOperand, secondOperand;

        public int FirstOperand
        {
            set
            {
                firstOperand = value;
            }
            get
            {
                return firstOperand;
            }
        }

        public int SecondOperand
        {
            set
            {
                secondOperand = value;
            }
            get
            {
                return secondOperand;
            }
        }

        public MathOperation()
        {
            firstOperand = 0;
            secondOperand = 0;
        }

        public int AddOperation()
        {
            return (firstOperand + secondOperand);          
        }

        public int SubtractOperation()
        {
            return (firstOperand - secondOperand);  
        }

        public int MultiplyOperation()
        {
            return (firstOperand * secondOperand);
        }

        public float DivisionOperation()
        {
            return (firstOperand / secondOperand);
        }
    }
}
