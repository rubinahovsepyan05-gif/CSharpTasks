namespace f_ex1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 5, 0, 3, 8, 0, 2 };
        int index = 0;
        //Առաջին ցիկլով զանգվածի սկզբում գրում եմ,0-ից բացի բոլոր թվերը
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)//եթե 0 լինի ինդեքսը չի աճի ու հաջորդ ոչ 0 թիվը կդրվի 0-ի փոխարեն
            {
                numbers[index] = numbers[i];
                index++;
            }
        }
        //Էս ցիկլով զանգվածի 0-ները գրում եմ զանգվածի վերջում
        for (int i = index; i < numbers.Length; i++)
        {
            numbers[i] = 0;
        }
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}