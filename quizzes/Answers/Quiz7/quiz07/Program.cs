using System;

namespace quiz07
{
    class Program
    {
        static void Main(string[] args)
        {
            Shotgun myShotgun = new Shotgun();
            myShotgun.sound();

            Rifle myRifle = new Rifle();
            myRifle.sound();

            Pistol myPistol = new Pistol();
            myPistol.sound();
        }
        interface IFirearm
        {
            void sound()//interface method
            {
                Console.WriteLine("I am a " + this.GetType().Name + " and I go PHEW!");
            }
        }
        class Shotgun : IFirearm
        {
            public void sound()
            {
                Console.WriteLine("I am a " + this.GetType().Name + " and I go BOOM!");
            }
        }
        class Rifle : IFirearm
        {
            public void sound()
            {
                Console.WriteLine("I am a " + this.GetType().Name + " and I go BANG!");
            }
        }
        class Pistol : IFirearm
        {
            public void sound()
            {
                Console.WriteLine("I am a " + this.GetType().Name + " and I go POP!");
            }
        }
    }
}


//Quiz 07 — Interfaces

//Create an interface IFirearm with one method declaration, a void method that prints a message to console.
//Then instantiate three objects, a Shotgun instance, a Rifle instance, and a Pistol instance that implement the
//interface. Note: You are creating objects of type IFirearm by using the three classes that implement the interface.
//In your main program, instantiate objects, all of type IFirearm. Use the three types Shotgun, Rifle, and Pistol
//to create the three instances. Put your Program class and your other classes in the same file. In other words, use
//the same template we used before except substitute the interface for the class.


//Here is the expected output.
//This is C Sharp quiz 7
//I am a shotgun and I go Boom
//I am a rifle and I go Bang
//I am a pistol and I go Pop
//Press any key to continue . . .
