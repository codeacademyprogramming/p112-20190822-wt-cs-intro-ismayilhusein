using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad (Name)");
            string name = Console.ReadLine();

            Console.WriteLine("Soyad (Surname)");
            string surname = Console.ReadLine();

            Console.WriteLine("ID");
            int idNumber = Convert.ToInt32(Console.ReadLine());

            AccountCredentials account = new AccountCredentials(name, surname, idNumber);

            int selected = -1;

            while(selected != 0)
            {
                Console.WriteLine();
                selected = displayMenu();
                switch (selected)
                {
                    case 1:
                        Console.WriteLine("Hesabin balansi:" + account.getBalance());
                        break;
                    case 2:
                        Console.WriteLine("Mebleg daxil edin");
                        int addAmount = Convert.ToInt32(Console.ReadLine());
                        account.addToBalance(addAmount);
                        break;
                    case 3:
                        Console.WriteLine("Mebleg daxil edin");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        account.withdrawFromBalance(withdrawAmount);
                        break;
                    case 4:
                        Console.WriteLine("Ad (Name)");
                        string updatedName = Console.ReadLine();
                        if (String.IsNullOrEmpty(updatedName))
                        {
                            updatedName = account.getFirstName();
                        }

                        Console.WriteLine("Soyad (Surname)");
                        string updateSurname = Console.ReadLine();
                        if (String.IsNullOrEmpty(updateSurname))
                        {
                            updatedName = account.getLastName();
                        }

                        Console.WriteLine("ID number");
                        string updatedIdNumberString = Console.ReadLine();
                        int updatedIdNumber;
                        if (String.IsNullOrEmpty(updatedIdNumberString))
                        {
                            updatedIdNumber = account.getIdNumber();
                        } else
                        {
                            updatedIdNumber = Convert.ToInt32(updatedIdNumberString);
                        }

                        account.updateCredentials(updatedName, updateSurname, updatedIdNumber);
                        break;
                    case 0:
                        break;
                }
            }

            Console.ReadLine();
        }

        static int displayMenu()
        {
            Console.WriteLine("1. Balansa bax");
            Console.WriteLine("2. Balans artir");
            Console.WriteLine("3. Balansdan sil");
            Console.WriteLine("4. Hesab məlumatlarını dəyiş");
            Console.WriteLine("0. Cixish");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
