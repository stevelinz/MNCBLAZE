using Microsoft.AspNetCore.Components;
using System.Text;

namespace BlazorComponents.Pages
{
    public class NotesChordsBase : ComponentBase
    {
        public string? OutPutMajorChords { get; set; }
        public string? OutPutScale { get; set; }
        protected void SortedScale()
        {
            Sender sender = new Sender();
            sender.workingArray();
            string scaleArray = sender.workingArray();
 
            string[] buildArray = { };
            List<string> list = new List<string>(buildArray.ToList());

            scaleArray.Trim();

            // convert string to array 
            string[] stringToArray = new string[] { };

            stringToArray = scaleArray.Split(" ");
            // sort array
            Array.Sort(stringToArray);

            // trim the array of notes
            stringToArray = stringToArray.Where(s => !string.
                            IsNullOrWhiteSpace(s)).ToArray();

            string[] notesMatch = { "C", "C#", "D", "D#", "E", "F",
                                    "F#", "G", "G#", "A", "A#", "B" };
            string[] newArray = { "X", "X", "X", "X", "X", "X",
                                  "X", "X", "X", "X", "X", "X" };

            for (int x = 0; x < stringToArray.Length; x++)
            {
                for (int k = 0; k < 12; k++)
                {
                    if (stringToArray[x] == notesMatch[k])
                    {
                        newArray[k] = stringToArray[x];
                    }
                }
            }

            // convert array to string  
            StringBuilder builder = new StringBuilder();
            foreach (string sendArray in newArray)
            {
                builder.Append(sendArray);
                builder.Append(" ");
            }
            string result = builder.ToString();

            foreach (var item in result)
            {
                result = result.Replace("X", " ");
            }

            OutPutScale = result;

            int i = 0;
            string foundThird = "X";
            string foundFifth = "X";
            string valueTonic = "X";
            string majorChord   = "Major: ";
            string fChord = "FAC ";
            // Major Chords
            while (i < 12)
            {
                valueTonic = newArray[i]; 
                if (i + 4 < 12 && newArray[i + 4] !="X") foundThird = newArray[i + 4];                  
                else if (i + 4 > 12 && newArray[i - 8] !="X") foundThird = newArray[i - 8]; 

                if (i + 7 < 12 && newArray[i + 7] !="X") foundFifth = newArray[i + 7];                 
                else if (i + 7 > 12 && newArray[i - 5] !="X") foundFifth = newArray[i - 5];

                if (newArray[i].Equals("F") && newArray[i + 4].Equals("A") && newArray[i - 5].Equals("C"))
                {
                    majorChord = majorChord + fChord;
                }
               

                if (foundThird !="X" && foundFifth !="X" && valueTonic !="X")
                {
                    majorChord = majorChord + valueTonic + foundThird + foundFifth + " ";
                }
 
               


                    valueTonic = "X"; foundThird ="X"; foundFifth ="X"; 
                i++;
            }
            OutPutMajorChords = majorChord;
            // end Major Chords
        }
    }
}
