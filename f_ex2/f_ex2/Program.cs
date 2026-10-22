namespace f_ex2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 2, 7, 4, 8, 2, 4, 9, 7 };
        int n=numbers.Length;//զանգվածի երկարությունը պահում եմ փոփոխականի մեջ,որ ընթացքում կարողանամ փոփոխեմ
        for (int i = 0; i < n; i++)
        {
            int count = 0;//count-ը օգտագործում եմ չկրկնվող տարրերը չտպելու համար
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                    numbers[j] = numbers[n - 1];
                    j--;
                    n--;//ջնջելուց հետո զանգվածի երկարությունը փոքրացնում եմ
                }
            }
            if (count > 0)
            {
                Console.Write(numbers[i] + " ");//տպում եմ կրկնվող տարրը
            }
        }
    }
}
