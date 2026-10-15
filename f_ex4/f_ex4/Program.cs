using System.ComponentModel.DataAnnotations;

namespace f_ex4;

class Program
{
    struct Number
    {
        public int value;
    }
    static void Main(string[] args)
    {
        Number[][] numbers =
        {

            new Number[]
            {
                new Number { value = 1 },
                new Number { value = 2 },
            },
            new Number[]
            {
                new Number { value = 3 },
                new Number { value = 4 },
                new Number { value = 5 },
            },
            new Number[]
            {
                new Number { value = 6 },
            },
            new Number[]
            {
                new Number { value = 7 },
                new Number { value = 8 },
            }
        };
        //տողերի երկարությունները գումարում եմ վերջնական զանգվածի երկ․-ը ստանալու համար
        int length = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            length+=numbers[i].Length;
        }
        Number[] result = new Number[length];
        int index = 0;
        //աստիճանաձև զանգվածի բոլոր տարրերը ավելացնում եմ նոր զանգվածում
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                result[index]=numbers[i][j];
                index++;
            }
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write(result[i].value + " ");
        }
    }
}