namespace LogicSpace
{
    public class Logic
    {
        public string noteStart = System.IO.File.ReadAllText(@"notes.txt");
        public void LogicCreate()
        {

            if (noteStart.Contains("C"))
            {
                StreamWriter sw = new("notes.txt", append: true);
                sw.Write("found c ");
            }

        }
    }
}