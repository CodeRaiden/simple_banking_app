using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        double AccountBalance = 0;

        double amount;

        int userDecision;
        do
        {
            int userChoice;
            do
            {

                Console.WriteLine("Welcome! What would you like to do?\n1. Deposit Account 2. Witdraw cash");
                bool userChoiceValid = int.TryParse(Console.ReadLine(), out userChoice);
                if (!userChoiceValid)
                {
                    Console.WriteLine("Invalid input detected. Please enter a valid number");
                    Console.WriteLine();
                }
            } while (userChoice != 1 && userChoice != 2);



            if (userChoice == 1)
            {
                Console.WriteLine("Enter an amount to deposit:");
                bool amountSuccess = double.TryParse(Console.ReadLine(), out amount);
                if (amountSuccess)
                {
                    DepositAmount(amount, ref AccountBalance);
                    Console.WriteLine("{0} has been credited to your account\nAvailable Balance: {1}", amount, AccountBalance);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong Input detected. Please enter a valid input");
                    Console.WriteLine();
                }

            }
            else if (userChoice == 2)
            {
                Console.WriteLine("Enter an amount to withdraw:");
                Console.WriteLine();
                bool amountSuccess = double.TryParse(Console.ReadLine(), out amount);
                if (amountSuccess)
                {
                    WithdrawAmount(amount, ref AccountBalance);
                    Console.WriteLine("{0} has been debited from your account\nAvailable Balance: {1}", amount, AccountBalance);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong Input detected. Please enter a valid input");
                    Console.WriteLine();
                }


            }
            Console.WriteLine("Would you like to perform another transaction? \nEnter 1 for \"Yes\" 2 for \"No\"");
            Console.WriteLine();
            bool userDecisionSuccess = int.TryParse(Console.ReadLine(), out userDecision);
        }
        while (userDecision == 1);
        if (userDecision == 2)
        {
            Console.WriteLine("Bye! Thanks for banking with us :)");
            Console.WriteLine();
        }
    }

    // Withdraw Method
    public static double WithdrawAmount(double WithdrawAmount, ref double userBalance)
    {
        userBalance -= WithdrawAmount;
        return userBalance;
    }

    // Deposit Method
    public static double DepositAmount(double DepositAmount, ref double userBalance)
    {
        userBalance += DepositAmount;

        return userBalance;
    }

}
