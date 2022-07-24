
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
                var operation = (MenuFunctions)int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case MenuFunctions.AddGrade:
                        {
                            AddStudentGrade(gradeJournal);
                            break;
                        }
                    case MenuFunctions.ChangeGrade:
                        {
                            ChangeStudentGrade(gradeJournal);
                            break;
                        }
                    case MenuFunctions.RemoveGrade:
                        {
                            RemoveStudentGrade(gradeJournal);
                            break;
                        }
                    case MenuFunctions.DisplayJournal:
                        {
                            DisplayAllJournal(gradeJournal);
                            break;
                        }
                    case MenuFunctions.DisplayAverage:
                        {
                            DisplayAverageRating(gradeJournal);
                            break;
                        }
                    case MenuFunctions.TopGradeStudents:
                        {
                            DisplayTopPerfomingStudents(gradeJournal);
                            break;
                        }
                    case MenuFunctions.EightOrHigherStudents:
                        {
                            DisplayStudentsWithEightOrHigherRating(gradeJournal);
                            break;
                        }
                    case MenuFunctions.FourOrLowerStudents:
                        {
                            DisplayStudentsWithFourOrLowerRating(gradeJournal);
                            break;
                        }
                    case MenuFunctions.Exit:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command");
                            ConsoleManager.ContinueWork();
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
            foreach (KeyValuePair<string, int> student in gradeJournal)
            {
                if (student.Value >= 4)
                {
                    Console.WriteLine(student.Key);
                }
            }
            ConsoleManager.ContinueWork();
        }

        private static void DisplayStudentsWithFourOrLowerRating(Dictionary<string, int> gradeJournal)
        {
            foreach (KeyValuePair<string, int> student in gradeJournal)
            {
                if (student.Value <=4)
                {
                    Console.WriteLine(student.Key);
                }
            }

            ConsoleManager.ContinueWork();
        }
    }
}
