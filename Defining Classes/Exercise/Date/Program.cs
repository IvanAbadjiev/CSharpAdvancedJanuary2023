namespace DateModifier
{

    public static class StarUp
    {
        public static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int different = DateModifier.GetDifference(start, end);

            Console.WriteLine(different);

        }

    }
}