using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Person();
            Person andrew = people[0];
            Console.WriteLine(andrew.Name ?? "привет");

            User user = new User();
            user["email"] = "andrei13081996@amil.ru";
            user["name"] = "Andrew";
            user["phone"] = "+375296189792";
            Console.WriteLine($"{user["email"]}, {user["name"]}, {user["phone"]}");

            Matrix array = new Matrix();
            Console.WriteLine(array[1, 2]);
            //array[1, 2] = 555;
            Console.WriteLine(array[1, 2]);

            OverloadingPeople overloadingPeople = new OverloadingPeople();
            overloadingPeople[0] = new OverloadingPerson();
            overloadingPeople[0].Name = "Vasya";
            overloadingPeople[0].Age = 25;
            overloadingPeople[1] = new OverloadingPerson();
            overloadingPeople[1].Name = "Kirill";
            Console.WriteLine(overloadingPeople[0].Age);
            Console.WriteLine(overloadingPeople["Vasya"].Age);


        }
    }
}
