using System;

namespace Num2_TestAndPractice
{
    class Person
    {
        private string name = "defName";

        public Person(string nameSet)
        {
            name = nameSet;
        }

        public override string ToString()
        {
            return $"Hello! My name is {name}";
        }

    }

    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(peopleFormater(createNewPeople(3)));
        }

        static string peopleFormater(object[] peopleArr)
        {
            string formatted = string.Join("\n", peopleArr);

            return formatted;
        }

        static object[] createNewPeople(int peopleAmount = 3)
        {
            Person[] people = new Person[peopleAmount];

            for (int i = 0; i < people.Length; i++)
            {
                string newPersonName = Console.ReadLine();

                people[i] = new Person(newPersonName);
            }

            return people;
        }

    }
}