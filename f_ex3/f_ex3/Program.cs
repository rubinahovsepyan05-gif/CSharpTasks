namespace f_ex3;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix =
        {
            { 2, 5, 1 },
            { 8, 1, 4 },
            { 3, 7, 6 },
            { 4, 2, 1 }
        };
        //առաջին տողի գումարը պահում եմ որպես ամենամեծ
        int row = -1;
        int maxsum = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            //տողերի գումարները համեմատում եմ ու պահում ամենամեշ գումարն ու դրա տողը
            if (sum > maxsum)
            {
                maxsum = sum;
                row = i;
            }
        }
        Console.WriteLine($"Row: {row}, Sum: {maxsum}");
    }
}
