namespace TASK_LEC_9
{
    internal static class HELPER
    {
        public static bool IsUnique(List<int> list, int value)
        {
            foreach (int item in list)
            {
                if (item == value) return false;
            }
            return true;
        }

        public static bool IsContainVowels(string text)
        {
            string vowels = "aeiouAEIOU";
            foreach (char c in text)
            {
                if (vowels.Contains(c)) return true;

            }
            return false;
        }


    }
}
