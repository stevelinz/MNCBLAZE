using Microsoft.AspNetCore.Components;
using System.Text;

namespace BlazorComponents.Pages
{
    public class NotesChordsBase : ComponentBase
    {
        public string? OutPutMajorChords { get; set; }
        public string? OutPutminorChords { get; set; }
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
            string[] arr = { "X", "X", "X", "X", "X", "X",
                                  "X", "X", "X", "X", "X", "X" };

            for (int x = 0; x < stringToArray.Length; x++)
            {
                for (int k = 0; k < 12; k++)
                {
                    if (stringToArray[x] == notesMatch[k])
                    {
                        arr[k] = stringToArray[x];
                    }
                }
            }

            // convert array to string  
            StringBuilder builder = new StringBuilder();
            foreach (string sendArray in arr)
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
            string major3rd = "X";
            string minor3rd = "X";
            string fifth = "X";
            string valueTonic = "X";
            string majorChord   = "Major: ";
            string minorChord = "minor: ";
            string fMajorChord = "FAC ";
            string fminorChord = "FG#C ";

            // Major Chords
            while (i < 12)
            {
                valueTonic = arr[i]; 
                if (i + 4 < 12 && arr[i + 4] !="X") major3rd = arr[i + 4];                  
                else if (i + 4 > 12 && arr[i - 8] !="X") major3rd = arr[i - 8]; 

                if (i + 7 < 12 && arr[i + 7] !="X") fifth = arr[i + 7];                 
                else if (i + 7 > 12 && arr[i - 5] !="X") fifth = arr[i - 5];

                // f is a special condition
                if (arr[i].Equals("F") && arr[i + 4].Equals("A") && arr[i - 5].Equals("C"))
                {
                    majorChord = majorChord + fMajorChord;
                }
                
                if (major3rd !="X" && fifth !="X" && valueTonic !="X")
                {
                    majorChord = majorChord + valueTonic + major3rd + fifth + " ";
                }
                    valueTonic = "X"; major3rd ="X"; fifth ="X"; //reset the test
                i++;
            }
            OutPutMajorChords = majorChord;
            // end Major Chords

            i = 0; //restart array
            while (i < 12) // minor Chords
            {
                valueTonic = arr[i];
                if (i + 3 < 12 && arr[i + 3] != "X") minor3rd = arr[i + 3];
                else if (i + 3 > 12 && arr[i - 9] != "X") minor3rd = arr[i - 9];

                if (i + 7 < 12 && arr[i + 7] != "X") fifth = arr[i + 7];
                else if (i + 7 > 12 && arr[i - 5] != "X") fifth = arr[i - 5];
                // f is a special condition
                if (arr[i].Equals("F") && arr[i + 3].Equals("G#") && arr[i - 5].Equals("C"))
                {
                    minorChord = minorChord + fminorChord;
                }
                if (minor3rd != "X" && fifth != "X" && valueTonic != "X")
                {
                    minorChord = minorChord + valueTonic + minor3rd + fifth + " ";
                }
                valueTonic = "X"; minor3rd = "X"; fifth = "X"; //reset test
                i++;
            }
            OutPutminorChords = minorChord;   // end minor Chords

        }
    }
}
