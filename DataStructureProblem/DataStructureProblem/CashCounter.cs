using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class CashCounter
    {


        QueueList<int> persons = new QueueList<int>();
        // QueueList<string> persons11 = new QueueList<string>();
        int acount_balancce;
        public void SetterAccountBalance(int data)
        {

            this.acount_balancce = data;
        }
        public int getterAccountBalance()
        {
            return this.acount_balancce;
        }
        // give msg to start page welcom
        public void startpage()
        {
            Console.WriteLine("--------WELCOME---------------");
            Console.WriteLine("welcome to ATM machine");
            Console.WriteLine("swap the  your card");

        }
        // inter pin for conformation

        //regex use for valid 4 digit pin code


        // public static string PinCode = "^[1,10]{4}$";
        //public bool Validation(string usercode)
        //{
        //    return Regex.IsMatch(usercode, PinCode);
        //}
        public void MultiPersonUse()
        {
            bool flag = true;
            while (flag)
            {

                startpage();

                PersonChoice();
                Console.WriteLine("do yow want recipite Y/N");
                char ch = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ch=='Y')
                {
                    PersonDetail();
                    Console.WriteLine("Thank You");
                }


                Console.WriteLine("Other Person add and enter yes");
                string confirm = Console.ReadLine().ToLower();
                if (confirm == "yes")
                {

                    continue;
                }
                else
                {
                    Console.WriteLine("Thank You");
                    break;

                }


            }

        }
        public void PersonChoice()
        {

            bool flag = true;
            while (flag)
            {



                Console.WriteLine("Hint 1 Deposit\n 2.withdraw  \n3.display balance \n4.list of total money add/withdraw \n5.First Tranversal money \n6.Cancel");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        DepositMoney();

                        break;
                    case 2:
                        Withdraw();
                        break;
                    case 3:
                        // only total balance
                        DisplayBalance();
                        break;
                    case 4:
                        //added balance
                        persons.Display();
                        break;
                    case 5:
                        persons.Peek();
                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("cancel");

                        break;




                }
            }


        }
        public void DepositMoney()
        {
            Console.WriteLine("Add the person");

            Console.WriteLine("Enter the Deposite money");
            int depositeValue = Convert.ToInt32(Console.ReadLine());
            persons.enqueue(depositeValue);
            this.acount_balancce +=depositeValue;
            Console.WriteLine("Total Balanace is " +this.acount_balancce);

        }
        public void Withdraw()
        {
            string userinput;
            do
            {
                Console.WriteLine("Enter the Withdraw money");
                int withdrawValue = Convert.ToInt32(Console.ReadLine());
                if (withdrawValue > 40000)
                {
                    Console.WriteLine("At Time Limit of AtM MACHINE IS 40000");
                    break;
                }
                else
                {
                    persons.Dequeue();

                    if (this.acount_balancce > withdrawValue)
                    {
                        this.acount_balancce -=withdrawValue;
                        Console.WriteLine("Total Balanace is " +this.acount_balancce);
                    }
                    else
                    {
                        Console.WriteLine("Insufficuent balance");
                    }

                }


                Console.WriteLine("Do you Reenter the money value yes /no");
                userinput = Console.ReadLine().ToLower();
            } while (userinput == "yes");



        }


        public void DisplayBalance()
        {

            if (this.acount_balancce == 0)
            {
                Console.WriteLine("Insufficuent balance");
            }
            else
            {
                Console.WriteLine(this.acount_balancce);
            }


        }
        public void PersonDetail()
        {
            try
            {
                string input = "hello <<FIRSTNAME>>, <<LASTNAME>> ";
                Console.WriteLine("enter the firstname");
                string Name = Console.ReadLine().ToUpper();
                input =input.Replace("<FIRSTNAME>>", Name);

                Console.WriteLine("enter the lastname");
                string fullname = Console.ReadLine();
                input =input.Replace("<<LASTNAME>>", fullname);


                Console.WriteLine("your Balance is " +this.acount_balancce);

                Console.WriteLine("Time"+DateTime.Now);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }



    }
}
