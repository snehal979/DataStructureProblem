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
                    case 2:
                    string filepaths = "C:\\Users\\hp\\Desktop\\newFolder\\DataStructureProblem\\DataStructureProblem\\DataStructureProblem\\orderSortData.txt";
                    OrderListcs orderList = new OrderListcs();
                    orderList.ReadFile(filepaths);
                    break;
                case 3:
                    string Balancefilepath = "C:\\Users\\hp\\Desktop\\newFolder\\DataStructureProblem\\DataStructureProblem\\DataStructureProblem\\StackBalance.txt";
                    BalancedParanthesiss balancedParanthesiss = new BalancedParanthesiss();
                    balancedParanthesiss.ReadFile(Balancefilepath);

                    break;
                case 4:
                    CashCounter Bank = new CashCounter();
                    Bank.SetterAccountBalance(10000);
                    Bank.MultiPersonUse(); 
                    break;
               

            }
        }
    }
}