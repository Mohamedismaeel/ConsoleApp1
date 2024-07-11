namespace ConsoleApp1
{
    using System;
    class student
    {

        string name;
        int id;
        int age;
        int ssn;
        string phone;
        public void print()
        {
            Console.WriteLine($"{name}-{age}-{ssn}-{phone}");
        }
    }

    class Program
    {
      



        static void Main()
        {
            student st1 = new student();
            student st2 = new student();
            st1.print();



            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1 ; i< 13; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i} ");
            }

            Console.WriteLine("enter your name :");
            string name = (Console.ReadLine());

            Console.WriteLine("enter your id :");
            int id = int.Parse(Console.ReadLine());
            int age;

            do
            {
                Console.WriteLine("please enter a correct age:");

                age = int.Parse(Console.ReadLine());
            }
            while (age < 0);
            Console.WriteLine($"name: {name}  -  id : {id}  -  age: {age}");
        }
    }

}