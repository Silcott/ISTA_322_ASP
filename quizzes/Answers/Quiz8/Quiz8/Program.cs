using System;

namespace Quiz8
{
    class Program
    {
        static void Main(string[] args)
        {
            Firearm pistol = new Firearm();
            pistol.Name = "pistol";
            pistol.Sound = "pop";
            pistol.Caliber = "9 mm";
            Console.WriteLine
                ("I am a " 
                + pistol.Name 
                + ", and I go " 
                + pistol.Sound 
                + " with a " 
                + pistol.Caliber 
                + ", and we have " 
                + Firearm.GetCount().ToString() 
                + " " 
                + pistol.GetType().Name 
                + "'s");

            Firearm rifle = new Firearm();
            rifle.Name = "rifle";
            rifle.Sound = "bang";
            rifle.Caliber = "7.62 mm";
            Console.WriteLine
                ("I am a " 
                + rifle.Name 
                + ", and I go " 
                + rifle.Sound 
                + " with a " 
                + rifle.Caliber 
                + ", and we have " 
                + Firearm.GetCount().ToString() 
                + " " 
                + rifle.GetType().Name + "'s");

            Firearm shotgun = new Firearm();
            shotgun.Name = "shotgun";
            shotgun.Sound = "boom";
            shotgun.Caliber = "12 gauge";
            Console.WriteLine
                ("I am a " 
                + shotgun.Name 
                + ", and I go " 
                + shotgun.Sound 
                + " with a " 
                + shotgun.Caliber 
                + ", and we have " 
                + Firearm.GetCount().ToString() 
                + " " + shotgun.GetType().Name 
                + "'s");
    }
        class Firearm
        {
            public string Name { get; set; }
            public string Sound { get; set; }
            public string Caliber { get; set; }

            private static int count = 0;
            public Firearm()
            {
                count++;
            }

            ~Firearm()
            {
                count--;
            }

            public static int GetCount()
            {
                count--;
                return count;
            }
        }
    }
}


//Quiz 08 — Automatic Properties
//C# Programming
//This is a timed test. You have thirty minutes to complete the test. When you finish the test, upload your
//Program.cs to Canvas. Do not publish your answer to your git repository.
//Do not create separate files for your class, but place your program and class in the same file as we did before.


//You will create a Firearm class with three automatic properties: Name, Sound, and Caliber.Also, create a class
//property of type int that increments the count of firearms as they are created. Write an appropriate constructor
//and a ToString() method.
//In your Program class, instantiate three objects, a rifle, a shsotgun, and a pistol and print them. Do not manually
//increment the count but have it implemented programatically. Put both the program class and your object class in
//the same file as we have done before.
//Here is the expected output.
//This is C Sharp quiz 8
//I am a pistol, and I go pop with a 9 mm round, and we have 1 firearms
//I am a rifle, and I go bang with a 7.62 mm round, and we have 2 firearms
//I am a shotgun, and I go bang with a 12 gauge round, and we have 3 firearms
//Press any key to continue . . .
