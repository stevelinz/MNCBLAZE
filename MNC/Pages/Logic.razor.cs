using Microsoft.AspNetCore.Components;
using System.Linq;

namespace BlazorComponents.Pages
{
    public class LogicBase : ComponentBase
    {   
        public string? OutPutLogic { get; set; }

        protected void test()
        {

            
            string temp = File.ReadAllText(@"notes.txt");

            StreamWriter noteId = new("notes.txt", append: true);

            int[] scaleArray = new int[24];

            if (temp.Contains("C"))
            {
                scaleArray[0] = 1;
                scaleArray[12] = 13;
            }
            if (temp.Contains("C#"))
            {
                scaleArray[1] = 2;
                scaleArray[13] = 14;
            }
            if (temp.Contains("D"))
            {
                scaleArray[2] = 3;
                scaleArray[14] = 15;
            }
            if (temp.Contains("D#"))
            {
                scaleArray[3] = 4;
                scaleArray[15] = 16;
            }
            if (temp.Contains("E"))
            {
                scaleArray[4] = 5;
                scaleArray[16] = 17;
            }
            if (temp.Contains("F"))
            {
                scaleArray[5] = 6;
                scaleArray[17] = 18;
            }
            if (temp.Contains("F#"))
            {
                scaleArray[6] = 7;
                scaleArray[18] = 19;
            }
            if (temp.Contains("G"))
            {
                scaleArray[7] = 8;
                scaleArray[19] = 20;
            }
            if (temp.Contains("G#"))
            {
                scaleArray[8] = 9;
                scaleArray[20] = 21;
            }
            if (temp.Contains("A"))
            {
                scaleArray[9] = 10;
                scaleArray[21] = 22;
            }
            if (temp.Contains("A#"))
            {
                scaleArray[10] = 11;
                scaleArray[22] = 23;
            }
            if (temp.Contains("B"))
            {
                scaleArray[11] = 12;
                scaleArray[23] = 24;
            }

            foreach (var item in scaleArray)
            {
                noteId.WriteLine(item + " ");
            }

            noteId.Close();

            OutPutLogic = File.ReadAllText(@"notes.txt");       
    }
       
    }
}
