using System;
using System.Linq;

namespace StudentsList
{
    internal class JournalManager
    {
        public static void LaunchJournalManager()
        {
            Dictionary<string, int> gradeJournal = Journal.CreateGradeJournal();
            while (true)
            {
                ConsoleManager.DisplayMenu();
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            AddStudentGrade(gradeJournal);
                            break;
                        }
                    case 2:
                        {
                            ChangeStudentGrade(gradeJournal);
                            break;
                        }
                    case 3:
                        {
                            RemoveStudentGrade(gradeJournal);
                            break;
                        }
                    case 4:
                        {
                            DisplayAllJournal(gradeJournal);
                            break;
                        }
                    case 5:
                        {
                            DisplayAverageRating(gradeJournal);
                            break;
                        }
                    case 6:
                        {
                            DisplayTopPerfomingStudents(gradeJournal);
                            break;
                        }
                    case 7:
                        {
                            DisplayStudentsWithEightOrHigherRating(gradeJournal);
                            break;
                        }
                    case 8:
                        {
                            DisplayStudentsWithFourOrLowerRating(gradeJournal);
                            break;
                        }
                    case 9:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command");
                            break;
                        }
                }
            }
        }

        private static void AddStudentGrade(Dictionary<string, int> gradeJournal)
        {
            Console.WriteLine("Enter student's surname from capital letter (case sensitive)");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter student's grade");
            int grade = int.Parse(Console.ReadLine());
            if (gradeJournal.ContainsKey(surname))
            {
                Console.WriteLine("This student is already in journal");
            }
            else
            {
                gradeJournal.Add(surname, grade);
            }

            ConsoleManager.ContinueWork();
        }

        private static void ChangeStudentGrade(Dictionary<string, int> gradeJournal)
        {
            Console.WriteLine("Enter student's surname from capital letter (case sensitive)");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter student's grade");
            int grade = int.Parse(Console.ReadLine());
            if (gradeJournal.ContainsKey(surname))
            {
                gradeJournal[surname] = grade;
            }
            else
            {
                Console.WriteLine("This student is not in group");
            }

            ConsoleManager.ContinueWork();
        }

        private static void RemoveStudentGrade(Dictionary<string, int> gradeJournal)
        {
            Console.WriteLine("Enter student's surname from capital letter (case sensitive)");
            string surname = Console.ReadLine();
            if (gradeJournal.ContainsKey(surname))
            {
                gradeJournal.Remove(surname);
                Console.WriteLine("Student successfully removed from the journal");
            }
            else
            {
                Console.WriteLine("This student is not in group");
            }

            ConsoleManager.ContinueWork();
        }

        private static void DisplayAllJournal(Dictionary<string, int> gradeJournal)
        {
            foreach (KeyValuePair<string, int> student in gradeJournal)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }

            ConsoleManager.ContinueWork();
        }

        private static void DisplayAverageRating(Dictionary<string, int> gradeJournal)
        {
            double averageGrade = gradeJournal.Values.Average();
            Console.WriteLine($"Average student's grade is {averageGrade}");
            ConsoleManager.ContinueWork();
        }

        private static void DisplayTopPerfomingStudents(Dictionary<string, int> gradeJournal)
        {
            var bestStudentTable = gradeJournal.Where(student => student.Value == gradeJournal.Values.Max()).ToList();
            foreach (var student in bestStudentTable)
            {
                Console.WriteLine(student.Key);
            }

            ConsoleManager.ContinueWork();
        }

        private static void DisplayStudentsWithEightOrHigherRating(Dictionary<string, int> gradeJournal)
        {
            var eightOrHigherStudentTable = gradeJournal.Where(student => student.Value >= 8).ToList();
            foreach (var student in eightOrHigherStudentTable)
            {
                Console.WriteLine(student.Key);
            }

            ConsoleManager.ContinueWork();
        }

        private static void DisplayStudentsWithFourOrLowerRating(Dictionary<string, int> gradeJournal)
        {
            var fourOrLowerStudentTable = gradeJournal.Where(student => student.Value <=4).ToList();
            foreach (var student in fourOrLowerStudentTable)
            {
                Console.WriteLine(student.Key);
            }

            ConsoleManager.ContinueWork();
        }
    }
}
