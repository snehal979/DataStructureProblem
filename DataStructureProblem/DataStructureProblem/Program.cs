namespace DataStructureProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    UnOrderLinkedList unOrderDataStructure = new UnOrderLinkedList();
                    string filepath = "C:\\Users\\hp\\Desktop\\newFolder\\DataStructureProblem\\DataStructureProblem\\DataStructureProblem\\UnorderData.txt";
                    unOrderDataStructure.ReadFile(filepath);
                    break;
            }
        }
    }
}