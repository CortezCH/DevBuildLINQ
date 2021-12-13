using System;
using System.Collections.Generic;
using System.Linq;

namespace DevBuildLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("Questions for Nums");
            //Question 1 for nums
            int numsMin = nums.Min();
            Console.WriteLine($"Question 1: {numsMin}");

            //Question 2 for nums
            int numsMax = nums.Max();
            Console.WriteLine($"Question 2: {numsMax}");

            //Question 3 for nums
            List<int> numsLessThan10000 = nums.Where(x => x < 10000).ToList();
            Console.WriteLine($"Question 3: {numsLessThan10000.Count} results found");

            //Question 4 for nums
            List<int> numsBetween10And100 = nums.Where(x => x >= 10 && x <= 100).ToList();
            Console.WriteLine($"Question 4: {numsBetween10And100.Count} results found");

            //Question 5 for nums
            List<int> numsBetween100000And999999 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.WriteLine($"Question 5: {numsBetween100000And999999.Count} results found");

            //Question 6 for nums
            int numberOfEvenNums = nums.Count(x => x % 2 == 0);
            Console.WriteLine($"Question 6: {numberOfEvenNums} number of even numbers");

            //-------------------------------------------------------------------------

            Console.WriteLine("Questions for Students");
            //Question 1 for Students
            List<Student> students21OrOver = students.Where(x => x.Age >= 21).ToList();
            Console.WriteLine($"Question 1: {students21OrOver.Count} students found over 21");

            //Question 2 for Students
            int maxStudentAge = students.Max(x => x.Age);
            Student oldestStudent = students.Where(x => x.Age == maxStudentAge).First();
            Console.WriteLine($"Question 2: {oldestStudent.Name} is the oldest student");

            //Question 3 for Students
            int minStudentAge = students.Min(x => x.Age);
            Student youngestStudent = students.Where(x => x.Age == minStudentAge).First();
            Console.WriteLine($"Question 3: {youngestStudent.Name} is the youngest student");

            //Question 4 for Students
            List<Student> studentsUnder25 = students.Where(x => x.Age < 25).ToList();
            int maxAgeUnder25 = studentsUnder25.Max(x => x.Age);
            Student oldestStudentUnder25 = students.Where(x => x.Age == maxAgeUnder25).First();
            Console.WriteLine($"Question 4: {oldestStudentUnder25.Name} is the oldest student under 25");

            //Question 5 for Students
            List<Student> studentsOver25WithEvenAge = students.Where(x => (x.Age > 21) && (x.Age % 2 == 0)).ToList();
            Console.WriteLine($"Question 5: {studentsOver25WithEvenAge.Count} students over 25 with an even age");

            //Question 6 for Students
            List<Student> teenageStudents = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            Console.WriteLine($"Question 6: {teenageStudents.Count} teenage students");

            //Question 7 for Students
            List<Student> studentsNameStartsWithVowel = students.Where(x => "aeiouAEIOU".IndexOf(x.Name[0]) != -1).ToList();
            Console.WriteLine($"Question 7: {studentsNameStartsWithVowel.Count} students whose name starts with a vowel");
            
        }
    }
}
