
namespace StudentsList
{
    internal class Journal
    {
        public static Dictionary<string, int> CreateGradeJournal()
        {
            return new Dictionary<string, int>()
            {
                {"Ivanov", 8 },
                {"Smith", 9 },
                {"Taylor", 10 },
                {"I", 10 }
            };
        }
    }
}
