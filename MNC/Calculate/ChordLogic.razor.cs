namespace BlazorComponents.Pages
{
    public class ChordLogic
    {
        public void chordCreated()
        {
            string temp = File.ReadAllText(@"scaleConvert.txt");

            StreamWriter scaleNumbers = new(@"chordLogic.txt", append: false);
        }
    }
}
