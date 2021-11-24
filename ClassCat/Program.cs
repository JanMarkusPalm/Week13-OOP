using System;

namespace ClassCat
{
    class Program
    {
        class cat
        {
            string name;
            string color;
            double hungryness; 

            public cat(string _name, string _color) //constructor
            {
                name = _name;
                color = _color;
                hungryness = 0;
            }

            public string Name //name getter
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungryness
            {
                get { return hungryness; }
            }
            public void sleeps()
            {
                Console.WriteLine("zzzzzzzzzzzzzz");
                hungryness += 0.2; //happiness +0.2
            }
            public void meows()
            {
                Console.WriteLine($"{name}: says \"meow!\"");


            }
            public void rename(string NewName)
            {
                Console.WriteLine($"Enter a new namefor the cat {Name}");
            }
            public void ShowcatData()
            {
                Console.WriteLine($"name:{name}");
                Console.WriteLine($"color:{color}");
                Console.WriteLine($"lvl of hungry:{hungryness}");
            }
        }


        static void Main(string[] args)
        {
            cat mycat = new cat("pätu", "must");
            while (mycat.Hungryness != 1)
            {
                mycat.sleeps();
            }
            mycat.meows();

            Console.WriteLine($"Enter a new namefor the cat {mycat.Name}.");
            string userinput = Console.ReadLine();
            mycat.rename(userinput);
            mycat.ShowcatData();
        }
    }
}
