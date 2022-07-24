using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    internal class ConsoleManager
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Press 1: Add student's grade \r\n" +
                "Press 2: Change the student's grade \r\n" +
                "Press 3: Remove the student grade \r\n" +
                "Press 4: Display all students in the form: Surname - Grade \r\n" +
                "Press 5: Display the average of all grades \r\n" +
                "Press 6: Display the names of students who have the highest grade among classmates \r\n" +
                "Press 7: Display the names of students who have grade greater than or equal to 8 \r\n" +
                "Press 8: Display the names of students who have grade less than or equal to 4 \r\n" +
                "Press 9: End programm");
        }

        public static void ContinueWork()
        {
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
