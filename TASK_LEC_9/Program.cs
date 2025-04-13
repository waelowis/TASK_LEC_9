namespace TASK_LEC_9
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 50, 60, 800, 100]);
            int x = 1;
            bool y = HELPER.IsUnique(list, x);
            if (y)
            {
                Console.WriteLine($" {x} it not found list");
            }
            else
            {
                throw new Exception($"{x} it found list");

            }

            string txt = "ssddffgghh";
            if (HELPER.IsContainVowels(txt))
            {
                Console.WriteLine("txt is contain Vowels");
            }
            else
            {
                throw new Exception($"{txt}  - does not contain vowels.");
            }

        }
    }
}
