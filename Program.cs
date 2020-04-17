using System;
using System.Collections.Generic;

namespace CSharpExam1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 2.a: Create 5 Employees then add to generic collection
            Employee emp1 = new Employee(1, "John", 60000);
            Employee emp2 = new Employee(2, "Patrick", 80000);
            Employee emp3 = new Employee(3, "Cameron", 40000);
            Employee emp4 = new Employee(4, "Melissa", 120000);
            Employee emp5 = new Employee(5, "Timmy", 75000);

            IList<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);

            //Question 2.b: Iterate through the list and write the name of the employee in the console
            foreach(Employee emp in empList)
            {
                Console.WriteLine(emp.name);
            }

            //Question 2.c: Use Delegate to find the highest and lowest salary among employees


            //Question 3: Use Tuple to create an object which has 3 fields (name, age, address) and print the fields in the console.
            Tuple<string, int, string> customer = new Tuple<string, int, string>("Sean", 27, "123 Street");

            //Question 3.a: Interpolation
            Console.WriteLine($"Name: {customer.Item1} Age: {customer.Item2} Address: {customer.Item3}");

            //Question 3.b: Format
            Console.WriteLine("Name: {0} Age: {1} Address: {2}", customer.Item1, customer.Item2, customer.Item3);

            //Question 4: Use Dictionary to keep the values of Information of 5 employees in question 2.
            //Question 4.a: Use employeeId as the key and the office address as the value. (No "Office Address" in Q2 so employee name is used)
            IDictionary<int, string> empDict = new Dictionary<int, string>();
            foreach(Employee emp in empList)
            {
                empDict.Add(emp.id, emp.name);
            }

            //Question 6: Use Extension method for integer to check if the number is dividable by 3
            int a = 32;
            int b = 21;
            bool resulta = a.IsMultiple3();
            bool resultb = b.IsMultiple3();
            Console.WriteLine("a is: {0} b is: {1}", resulta, resultb);

            //Question 7: Write a method that has one string parameter. By Using predicate check if that string has vowel sounds and print all the vowel sounds in the output.
            Predicate<string> vowelChecker = hasVowels;
            string test1 = "I have Vowels";
            string test2 = "qwrtz";
            if (vowelChecker(test1))
            {
                printVowels(test1);
            }
            if (vowelChecker(test2))
            {
                printVowels(test2);
            }
        }

        public static bool hasVowels(string sentence)
        {

            bool vowels = false;

            foreach(char letter in sentence)
            {
                if(letter.Equals('A') || letter.Equals('E') || letter.Equals('I') || letter.Equals('O') || letter.Equals('U') ||
                    letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') || letter.Equals('u'))
                {
                    vowels = true;
                }
            }
            return vowels;
        }

        public static void printVowels(string sentence)
        {
            foreach (char letter in sentence)
            {
                if (letter.Equals('A') || letter.Equals('E') || letter.Equals('I') || letter.Equals('O') || letter.Equals('U') ||
                    letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') || letter.Equals('u'))
                {
                    Console.Write(letter);
                }
            }
        }
    }
}
