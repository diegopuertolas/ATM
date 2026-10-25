using System.Runtime.ConstrainedExecution;

public static class AppMenu
{
    public static void DisplayMenu(decimal balance)
    {
        var option = -1;

        do
        {
            ShowMenu();
            option = ChooseOption();

            switch(option)
            {
                case 1:
                    Console.WriteLine();
                    CheckBalance(balance);
                    break;
                case 2:
                    Console.WriteLine();
                    DepositMoney(balance);
                    break;
                case 3: 
                    Console.WriteLine();
                    WithdrawMoney(balance);
                    break;
                case 0:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\n Opción no válida. Introduzca un número del 0 al 3");
                    break;
            }
            
        } while (option != 0);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n=== CAJERO ===");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Ingresar dinero");
        Console.WriteLine("3. Retirar dinero");
        Console.WriteLine("0. Salir");
    }

    public static int ChooseOption()
    {
        Console.Write("\n Eliga una opción: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            return -1;
        }

        return decision;
    }

    public static void CheckBalance(decimal balance)
    {
        Console.WriteLine($"Su saldo es de: {balance:C}");
    } 
    
    public static void DepositMoney(decimal balance)
    {
        Console.Write("\nIntroduzca la cantidad a ingresar: ");
        var input = Console.ReadLine();

        if (!decimal.TryParse(input, out var decision))
        {
            Console.WriteLine("\nIntroduza una cantidad correcta.");
            return;
        }

        if (decision <= 0)
        {
            Console.WriteLine("\nNo puede ingresar una cantidad negativa.");
            return;
        }

        balance += decision;

        Console.WriteLine($"Ha ingresado {decision:C}");
        CheckBalance(balance);
    }

    public static void WithdrawMoney(decimal balance)
    {
        Console.Write("\nIntroduzca la cantidad a retirar: ");
        var input = Console.ReadLine();

        if (!decimal.TryParse(input, out var decision))
        {
            Console.WriteLine("\nIntroduza una cantidad correcta.");
            return;
        }

        if (decision > balance)
        {
            Console.WriteLine("\nNo puede retirar una cantidad superior al saldo.");
            return;
        }

        balance -= decision;

        Console.WriteLine($"Ha retirado {decision:C}");
        CheckBalance(balance);
    }
}