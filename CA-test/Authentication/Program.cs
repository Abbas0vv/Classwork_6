using Authentication.Commands;
using Authentication.Database;
using Authentication.Utilities;

namespace Authentication
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            DataContext database = new DataContext();

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
                        RegisterCommand registerCommand = new RegisterCommand();
                        registerCommand.Handle(database);
                        break;
                    case "/login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle(database);
                        break;
                    case "/exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
