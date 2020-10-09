using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace progEx09_PasswordHashing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashing Method
            string CalculateSHA256(string str)
            {
                SHA256 sha256 = SHA256.Create();
                byte[] hashValue;
                hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));
                //Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashValue.Length; i++)
                {
                    builder.Append(hashValue[i].ToString("x2"));
                }
                return builder.ToString();
            }

            //Create a dictionary to hold the username as Keys and the passwords as Values
            Dictionary<string, string> UserDataDict = new Dictionary<string, string>() { };

            //Introduction to Exercise
            Intro();

            //Variables for users names, passwords, and hased passwords
            string user = GetUserName();
            string password = GetUserPassword();
            var hashedPassword = CalculateSHA256(password);

            //Log In Method
            LogIn();

            //User Interface Screen
            PrintUI();

            //Intro Method explaining Exercise
            void Intro()
            {
                Console.WriteLine("This is the hashing and authentication programming exercise.");
                Console.WriteLine("In order to run this program, enter the first username and password.");
                Console.WriteLine("After you enter the first user, follow the instructions.\n\n");
            }
            //Ask and store user name
            string GetUserName()
            {
                string userName;
                Console.WriteLine("Enter a new user name: ");

                return userName = Console.ReadLine().ToString();
            }
            //Ask and store user password
            string GetUserPassword()
            {
                string userPassword;
                Console.WriteLine("Enter a password for the new user: ");
                return userPassword = Console.ReadLine().ToString();
            }
            //Log in Method
            void LogIn()
            {
                //UserDataDict.Add(Util.GetUserName(), Util.GetUserPassword());
                if (UserDataDict.ContainsKey(user) && UserDataDict.ContainsValue(hashedPassword))
                {
                    Console.WriteLine($"Welcome back {user}");
                }
                else if (UserDataDict.ContainsKey(user) && !UserDataDict.ContainsValue(hashedPassword))
                {
                    Console.WriteLine("Incorect Password, Try Agin");
                    LogIn();
                }
                else
                {
                    //UserDataDict.Add(Util.GetUserName(), Util.GetUserPassword());
                    UserDataDict.Add(user, hashedPassword);
                    Console.WriteLine("You are new and I have added you to our database.  Welcome!");
                }
            }
            //Print all users
            void PrintUsers()
            {
                Console.WriteLine("\n\nPrinting usernames and passwords:");
                foreach (KeyValuePair<string, string> user in UserDataDict)
                {
                    string name = user.Key;
                    string pass = user.Value.ToString();
                    Console.WriteLine($"username: {name}, password: {pass}");
                }
            }
            //User Interface
            void PrintUI()
            {
                Console.WriteLine(@"
PASSWORD AUTHENTICATION SYSTEM
Please select one option:
1. Establish an account
2. Authenticate a user
3. View all users
4. Exit the system
Enter selection:
");
                try
                {
                    //Add New User & Password
                    int userInterfaceResponse = Convert.ToInt32(Console.ReadLine());
                    if (userInterfaceResponse == 1)
                    {
                        string user = GetUserName();

                        if (!UserDataDict.ContainsKey(user))
                        {
                            string password = GetUserPassword();
                            var hashedPassword = CalculateSHA256(password);
                            UserDataDict.Add(user, hashedPassword);
                            Console.WriteLine($"Username: {user}, has been added");
                        }
                        else
                        {
                            Console.WriteLine($"Username: {user}, already exists");
                            userInterfaceResponse = 0;
                            PrintUI();
                        }
                        
                    }
                    //Authentication
                    else if (userInterfaceResponse == 2)
                    {
                        Console.WriteLine("Enter users name: ");
                        string usernameAuthResponse = Console.ReadLine().ToString();
                        if (!UserDataDict.ContainsKey(usernameAuthResponse))
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine($"{usernameAuthResponse} does not exist in the users file.");
                            Console.WriteLine("-----------------------------------");
                            PrintUI();
                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine($"{usernameAuthResponse} exists in the user file.");

                        }
                        Console.WriteLine("Enter users password: ");
                        string userpasswordAuthResponse = Console.ReadLine().ToString();
                        if (password != userpasswordAuthResponse)
                        {
                            Console.WriteLine($"{usernameAuthResponse}'s password does not match the correct password.");
                            Console.WriteLine("---------not authenticated---------");
                        }
                        else
                        {
                        Console.WriteLine("-----------authenticated-----------");
                        }
                    }
                    //Print All Users
                    else if (userInterfaceResponse == 3)
                    {
                        PrintUsers();
                        PrintUI();
                    }
                    else if (userInterfaceResponse == 4)
                    {
                        Console.WriteLine("Have a great day!" +
                            "\nExiting...");
                        Environment.Exit(0);
                    }
                    //Wrong Format
                    else
                    {
                        Console.WriteLine("Sorry, I didn't understand you, try again: ");
                        PrintUI();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect Format: Sorry, I didn't understand you, try again: ");
                    PrintUI();
                }
                PrintUI();
            }
        }
    }
}
