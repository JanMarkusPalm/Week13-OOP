using System;

namespace OOP_Part1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots) //constructor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");
            }

            public string Name //name getter
            {
                get { return name;}
            }
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("woof");
                happiness+= 0.2; //happiness +0.2
            }
            public void Wags()
            {
                Console.WriteLine("*wiggle*");
            
            }
            public void rename(string NewName)
            {
                Console.WriteLine($"Enter a new namefor the dog {Name}");
            }
            public void ShowDogData()
            {
                Console.WriteLine($"name:{name}");
                Console.WriteLine($"spots:{spots}");
                Console.WriteLine($"lvl of happy:{happiness}");
            }
        }


        static void Main(string[] args)
        {
            Dog myDog = new Dog("koer", 15);
            myDog.Barks();
            Console.WriteLine($"{myDog.Name}'s level of happiness is {myDog.Happiness}");
            Dog urDog = new Dog("kutt", 100);
            Console.WriteLine($"{urDog.Name}'s level of happiness is {urDog.Happiness}");

            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Wags();

            Console.WriteLine($"Enter a new namefor the dog {myDog.Name}");
            string userinput = Console.ReadLine();
            myDog.rename(userinput);
            myDog.ShowDogData();
        }
    }
}
