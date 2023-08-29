using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static Dictionary<String, String> users = new Dictionary<string, string>()
        {
            {"Kivanc","1234"},
            {"admin","root" },
            {"Dummy","dummy1234"}

        };

        static Dictionary<String, Double> balances = new Dictionary<string, double>()
        {
            {"Kivanc",10000},
            {"Dummy",150 },
        };

        static List<String> transactions = new List<string>();

        static List<String>frauds = new List<String>();

        static string currentUser = null;
        static void Main(string[] args)
        {
         
            while (true)
            {
                Console.WriteLine("Xbank ATM'ye Hoşgeldiniz");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seciniz: ");
                Console.WriteLine("1-Giriş Yap");
                Console.WriteLine("2-Çıkış Yap");
                string option = Console.ReadLine();
                if (int.TryParse(option, out int input))
                {
                    switch (input)
                    {
                        case 1:
                            Login();
                            break;
                            
                        case 2:
                            Exit();
                            break;
                        default:
                            Error("Geçersiz işlem");
                            continue;
                    }
                }
                else
                {
                    Error("Bir sayı Girmeniz gerekli");
                    continue;
                }
            }
               
            
        }
        static void Login()
        {
            Console.WriteLine("Kullanıcı adınız: ");
            string username = Console.ReadLine();
            Console.WriteLine("Parolanız: ");
            string password = Console.ReadLine();
            if(users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("Giriş Başarılı");
                currentUser = username;
                Menu();
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
                frauds.Add($"{username} tarafından başarısız giriş denemesi {DateTime.Now}");
                Main(null);
            }
        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Lütfen bir işlem secin /ç: ");
                Console.WriteLine("1. Para Çek");
                Console.WriteLine("2. Para Yatır");
                Console.WriteLine("3. Ödeme Yap");
                Console.WriteLine("4. Bakiye");
                Console.WriteLine("5. Çıkış Yap");
                Console.WriteLine("6. Gün sonu al");
                string option = Console.ReadLine();
                if(option=="ç" || option == "Ç")
                {
                    break;
                }
                if(int.TryParse(option, out int input))
                {
                    switch (input)
                    {
                        case 1:
                            withdraw();
                            break;
                        case 2:
                            Deposit();
                            break;
                        case 3:
                            Pay();
                            break;
                        case 4:
                            Balance();
                            break;
                        case 5:
                            LogOut();
                            break;
                        case 6:
                            if (currentUser == "admin")
                            {
                                EndOfDay();
                            }
                            else
                            {
                                Error("Sadece adminler erişebilir");
                            }
                            
                            break;

                        default:
                            Error("Geçersiz bir işlem seçtiniz");
                            break;

                    }
                }
                else
                {
                    Error("Geçersiz İşlem, Lütfen 1-6 Arasındaki rakamlardan birini seçiniz");
                    continue;
                }
            }
            

        }
        static void withdraw()
        {
            while (true)
            {
                Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz /ç : ");
                string input = Console.ReadLine();
                if (input == "ç" || input == "Ç")
                {
                    break;
                }
                if (int.TryParse(input, out int amount))
                {
                    if (amount > 0 && amount <= balances[currentUser])
                    {
                        balances[currentUser] -= amount;
                        transactions.Add($"{currentUser} Hesabından {amount} para çekildi {DateTime.Now}");
                        Console.WriteLine($"Hesabınızda {amount} para çektiniz");
                        break;

                    }
                    else
                    {
                        Error("Girdiğiniz miktar geçersiz");
                        continue;
                    }
                }
                else
                {
                    Error("Geçersiz işlem");
                    continue;
                }
            }
            
        }
        static void Deposit()
        {
            while (true)
            {
                Console.WriteLine("Lütfen Yatırmak istediğiniz tutarı giriniz /ç: ");
                string input = Console.ReadLine();
                if (input == "ç" || input == "Ç")
                {
                    break;
                }
                if (int.TryParse(input, out int amount))
                {
                    if (amount > 0)
                    {
                        balances[currentUser] += amount;
                        transactions.Add($"{currentUser} Hesabına {amount} miktar para yatırdı {DateTime.Now}");
                        Console.WriteLine($"Hesabınıza {amount} miktar para yatırıldı");
                        break;
                    }
                    else
                    {
                        Error("Geçersiz bir sayı girdiniz");
                        continue;
                    }
                }
                else
                {
                    Error("Lütfen sayı olarak giriniz");
                    continue;
                }
            }
           
        }
        static void Pay()
        {
            while (true)
            {
                Console.WriteLine("Ödemek istediğiniz Faturanın Ne faturası olduğunu yazınız /ç: ");
                string bill = Console.ReadLine();
                Console.WriteLine("Faturanın tutarını giriniz: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int amount))
                {
                    if (amount > 0 && balances[currentUser] >= amount)
                    {
                        balances[currentUser] -= amount;
                        transactions.Add($"{currentUser} {amount} {bill} faturası ödedi {DateTime.Now}");
                        Console.WriteLine($"{bill} faturası ödendi tutar : {amount}");
                        break;
                    }
                    else
                    {
                        Error("İşlem Başarısız");
                        continue;
                    }
                }
                else
                {
                    Error("Geçersiz işlem");
                    continue;
                }
            }
           
        }
        static void Balance()
        {
            Console.WriteLine($"Hesabında toplam {balances[currentUser]} kadar para var");
        }
        static void LogOut()
        {
            Console.WriteLine("Hesabınızdan Çıkış Yaptınız");
            currentUser = null;
            Main(null);
        }
        static void Exit()
        {
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz yeniden bekleriz..");
            Environment.Exit(0);
        }
        static void EndOfDay()
        {
            Console.WriteLine("Gün Sonu raporu: ");
            Console.WriteLine("İşlemler: ");
            foreach(string transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine("Hatalı işlemler: ");
            foreach(string fraud in frauds)
            {
                Console.WriteLine(fraud);
            }
            string fileName = $"EOD_{DateTime.Now.ToString("ddMMyyyy")}.txt";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Gün sonu raporu: ");
                writer.WriteLine("İşlemler: ");
                foreach (string transaction in transactions)
                {
                    writer.WriteLine(transaction);
                }
                writer.WriteLine("Hatalı işlemler:");
                foreach (string fraud in frauds)
                {
                    writer.WriteLine(fraud);
                }

            }
            Console.WriteLine($"Günlük işlem raporu yazıldı {filePath}");

        }
        static void Error(string err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err);
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
