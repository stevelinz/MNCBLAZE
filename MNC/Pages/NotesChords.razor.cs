using Microsoft.AspNetCore.Components;
using System.Text;

namespace BlazorComponents.Pages
{
    public class NotesChordsBase : ComponentBase
    {
        public string? OutPutMajorChords { get; set; }
        public string? OutPutMajorDom7thChords { get; set; }
        public string? OutPutMajor7thChords { get; set; }
        public string? OutPutminorChords { get; set; }
        public string? OutPutminor7thChords { get; set; }
        public string? OutPutminor7thFlat5Chords { get; set; }
        public string? OutPutminorPenta { get; set; }
        public string? OutPutScale { get; set; }

        public int count = 0;

        protected void ReverseMajor()
        {
            if (count == 1) OutPutMajorChords = OutPutMajorChords;
            if (OutPutMajorChords is null)  OutPutMajorChords = "123456 first button other click";   
            string result = "";
            List<string> wordsList = new List<string>();
            if (OutPutMajorChords.Length < 6) OutPutMajorChords = " Once Click */*/ Once";
            OutPutMajorChords = OutPutMajorChords.Substring(6);
            string[] words = OutPutMajorChords.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);

            foreach (String s in wordsList)
            {
                OutPutMajorChords = s + OutPutMajorChords;
            }
        }
        protected void Reverseminor()
        {
            if (count == 1) OutPutminorChords = OutPutminorChords;
            if (OutPutminorChords is null) OutPutminorChords = "123456 first button other click";
            string result = "";
            List<string> wordsList = new List<string>();
            if (OutPutminorChords.Length < 6) OutPutminorChords = " Once Click */*/ Once";
           OutPutminorChords = OutPutminorChords.Substring(6);
            string[] words = OutPutminorChords.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
                count = 1;
            }
            wordsList.Add(result);

            foreach (String s in wordsList)
            {
                OutPutminorChords = s + OutPutminorChords;
            }
        }

        protected void ReversePentatonic()
        {
            if (count == 1) OutPutminorPenta = OutPutminorPenta;
            if (OutPutminorPenta is null) OutPutminorPenta = "123456 first button other click";
            string result = "";
            List<string> wordsList = new List<string>();
            if (OutPutminorPenta.Length < 6) OutPutminorPenta = " Once Click */*/ Once";
            OutPutminorPenta = OutPutminorPenta.Substring(6);
            string[] words = OutPutminorPenta.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
                count = 1;
            }
            wordsList.Add(result);

            foreach (String s in wordsList)
            {
                OutPutminorPenta = s + OutPutminorPenta;
            }
        }

        // OutPutMajorChords.Intersect(OutPutminorChords);
        //OutPutMajorDom7thChords.Reverse();
        //OutPutMajor7thChords.Reverse();
        //OutPutminorChords.Reverse();
        //OutPutminor7thChords.Reverse();
        //OutPutminor7thFlat5Chords.Reverse();
        //OutPutminorPenta.Reverse();
        //OutPutScale.Reverse();


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

            string[] notesMatch = {"C", "C#", "D", "D#", "E", "F",
                                    "F#", "G", "G#", "A", "A#", "B", "Z" };
            string[] arrOriginal = {"X", "X", "X", "X", "X", "X", "X",
                                  "X", "X", "X", "X", "X" };
            string[] arr =         {"X", "X", "X", "X", "X", "X", "X",
                                  "X", "X", "X", "X", "X", "X" };

  

 
            for (int x = 0; x < stringToArray.Length; x++)
            {
                for (int k = 0; k < 13; k++)
                {
                    if (stringToArray[x] == notesMatch[k])
                    {
                        arrOriginal[k] = stringToArray[x];
                    }
                }
            }
            int move = 1;
            for (int x = 0; x < arrOriginal.Length; x++)
            {
                arr[move] = arrOriginal[x];
                move++; 
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

            int i = 1;
            string major3rd = "X";
            string minor3rd = "X";
            string fourth = "X";    
            string fifth = "X";
            string flat5 = "X";
            string major7th = "X";  
            string dom7th = "X";
            string valueTonic = "X";
            string majorChord = "Major: ";
            string majorDom7thChord = "Dom7th: ";
            string major7thChord = "Major7th: ";
            string minorChord = "minor: ";
            string minor7thChord = "minor7th: ";
            string minor7thFlat5Chord = "minor7thFlat5: ";
            string minorPenatonic = "minPen ";



            // MajorDom7th Chords ====================
            if (arr[6].Equals("F") && arr[10].Equals("A")
                && arr[1].Equals("C") && arr[4].Equals("D#")) majorDom7thChord += "FACD# ";
            if (arr[9].Equals("G#") && arr[1].Equals("C")
                && arr[4].Equals("D#") && arr[7].Equals("F#")) majorDom7thChord += "G#CD#F# ";
            if (arr[3].Equals("D") && arr[7].Equals("F#")
                && arr[10].Equals("A") && arr[1].Equals("C")) majorDom7thChord += "DF#AC ";
            i = 0;
            while (i < 13)
            {
                valueTonic = arr[i];
                if (i + 4 < 13 && arr[i + 4] != "X") major3rd = arr[i + 4];
                else if (i + 4 > 13 && arr[i - 8] != "X") major3rd = arr[i - 8];

                if (i + 7 < 13 && arr[i + 7] != "X") fifth = arr[i + 7];
                else if (i + 7 > 13 && arr[i - 5] != "X") fifth = arr[i - 5];

                if (i + 10 < 13 && arr[i + 10] != "X") dom7th = arr[i + 10];
                else if (i + 10 > 13 && arr[i - 2] != "X") dom7th = arr[i - 2];

                if (valueTonic != "X" && major3rd != "X" && fifth != "X" && dom7th != "X")
                    majorDom7thChord = majorDom7thChord + valueTonic + major3rd + fifth + dom7th + " ";

                valueTonic = "X"; major3rd = "X"; fifth = "X"; dom7th = "X"; //reset the test
                i++;
            }
            OutPutMajorDom7thChords = majorDom7thChord;
            // end MajorDom7th Chords ================

            // Major7th Chords ====================
            if (arr[6].Equals("F") && arr[10].Equals("A")
                && arr[1].Equals("C") && arr[5].Equals("E")) major7thChord += "FACE ";
            if (arr[9].Equals("G#") && arr[1].Equals("C")
                && arr[4].Equals("D#") && arr[8].Equals("G")) major7thChord += "G#CD#G ";
            i = 0;
            while (i < 13)
            {
                valueTonic = arr[i];
                if (i + 4 < 13 && arr[i + 4] != "X") major3rd = arr[i + 4];
                else if (i + 4 > 13 && arr[i - 8] != "X") major3rd = arr[i - 8];

                if (i + 7 < 13 && arr[i + 7] != "X") fifth = arr[i + 7];
                else if (i + 7 > 13 && arr[i - 5] != "X") fifth = arr[i - 5];

                if (i + 11 < 13 && arr[i + 11] != "X") major7th = arr[i + 11];
                else if (i + 10 > 13 && arr[i - 1] != "X") major7th = arr[i - 1];

                if (valueTonic != "X" && major3rd != "X" && fifth != "X" && major7th != "X")
                    major7thChord = major7thChord + valueTonic + major3rd + fifth + major7th + " ";

                valueTonic = "X"; major3rd = "X"; fifth = "X"; dom7th = "X"; //reset the test
                i++;
            }
            OutPutMajor7thChords = major7thChord;
            // end Major7th Chords ================

            // minor7th Chords ====================
            if (arr[6].Equals("F") && arr[9].Equals("G#")
                && arr[1].Equals("C") && arr[4].Equals("D#")) minor7thChord += "FG#CD# ";
            if (arr[3].Equals("D") && arr[6].Equals("F")
                && arr[10].Equals("A") && arr[1].Equals("C")) minor7thChord += "DFAC ";
            if (arr[10].Equals("A") && arr[1].Equals("C")
                && arr[5].Equals("E") && arr[8].Equals("G")) minor7thChord += "ACEG ";
            i = 0;
            while (i < 13)
            {
                valueTonic = arr[i];
                if (i + 3 < 13 && arr[i + 3] != "X") minor3rd = arr[i + 3];
                else if (i + 3 > 13 && arr[i - 9] != "X") minor3rd = arr[i - 9];

                if (i + 7 < 13 && arr[i + 7] != "X") fifth = arr[i + 7];
                else if (i + 7 > 13 && arr[i - 5] != "X") fifth = arr[i - 5];

                if (i + 10 < 13 && arr[i + 10] != "X") dom7th = arr[i + 10];
                else if (i + 10 > 13 && arr[i - 2] != "X") dom7th = arr[i - 2];

                if (valueTonic != "X" && minor3rd != "X" && fifth != "X" && dom7th != "X")
                    minor7thChord = minor7thChord + valueTonic + minor3rd + fifth + dom7th + " ";

                valueTonic = "X"; minor3rd = "X"; fifth = "X"; dom7th = "X"; //reset the test
             i++;
            }
            OutPutminor7thChords = minor7thChord; // end minor7th Chords ================

            // minor Penatonic ====================
            if (arr[6].Equals("F") && arr[9].Equals("G#") && arr[11].Equals("A#")
                && arr[1].Equals("C") && arr[4].Equals("D#")) minorPenatonic += "FG#A#CD# ";
            if (arr[3].Equals("D") && arr[6].Equals("F") && arr[8].Equals("G")
                && arr[10].Equals("A") && arr[1].Equals("C")) minorPenatonic += "DFGAC ";
            if (arr[10].Equals("A") && arr[1].Equals("C") && arr[3].Equals("D")
                && arr[5].Equals("E") && arr[8].Equals("G")) minorPenatonic += "ACDEG ";
            if (arr[8].Equals("G") && arr[11].Equals("A#") && arr[1].Equals("C")
                && arr[3].Equals("D") && arr[6].Equals("F")) minorPenatonic += "GA#CDF ";
            i = 0;
            while (i < 13)
            {
                valueTonic = arr[i];
                if (i + 3 < 13 && arr[i + 3] != "X") minor3rd = arr[i + 3];
                else if (i + 3 > 13 && arr[i - 9] != "X") minor3rd = arr[i - 9];

                if (i + 5 < 13 && arr[i + 5] != "X") fourth = arr[i + 5];
                else if (i + 5 > 13 && arr[i - 7] != "X") fourth = arr[i - 7];

                if (i + 7 < 13 && arr[i + 7] != "X") fifth = arr[i + 7];
                else if (i + 7 > 13 && arr[i - 5] != "X") fifth = arr[i - 5];

                if (i + 10 < 13 && arr[i + 10] != "X") dom7th = arr[i + 10];
                else if (i + 10 > 13 && arr[i - 2] != "X") dom7th = arr[i - 2];

                if (valueTonic != "X" && minor3rd != "X" && fifth != "X" && fourth != "X" && dom7th != "X")
                    minorPenatonic = minorPenatonic + valueTonic + minor3rd + fourth + fifth + dom7th + " ";

                valueTonic = "X"; minor3rd = "X"; fifth = "X"; fourth = "X"; dom7th = "X"; //reset the test
                i++;
            }
            OutPutminorPenta = minorPenatonic; // end  minor Penatonic ================

            // minor7thFlat5 Chords ====================
            if (arr[7].Equals("F#") && arr[10].Equals("A")
                && arr[1].Equals("C") && arr[5].Equals("E")) minor7thFlat5Chord += "F#ACE ";
            if (arr[3].Equals("D") && arr[6].Equals("F")
                && arr[9].Equals("G#") && arr[1].Equals("C")) minor7thFlat5Chord += "DFG#C ";
            if (arr[10].Equals("A") && arr[1].Equals("C")
                && arr[4].Equals("D#") && arr[8].Equals("G")) minor7thFlat5Chord += "ACD#G ";
            i = 0;
            while (i < 13)
            {
                valueTonic = arr[i];
                if (i + 3 < 13 && arr[i + 3] != "X") minor3rd = arr[i + 3];
                else if (i + 3 > 13 && arr[i - 9] != "X") minor3rd = arr[i - 9];

                if (i + 6 < 13 && arr[i + 6] != "X") flat5 = arr[i + 6];
                else if (i + 6 > 13 && arr[i - 6] != "X") flat5 = arr[i - 6];

                if (i + 10 < 13 && arr[i + 10] != "X") dom7th = arr[i + 10];
                else if (i + 10 > 13 && arr[i - 2] != "X") dom7th = arr[i - 2];

                if (valueTonic != "X" && minor3rd != "X" && flat5 != "X" && dom7th != "X")
                    minor7thFlat5Chord = minor7thFlat5Chord + valueTonic + minor3rd + flat5 + dom7th + " ";

                valueTonic = "X"; minor3rd = "X"; flat5 = "X"; dom7th = "X"; //reset the test
                i++;
            }
            OutPutminor7thFlat5Chords = minor7thFlat5Chord; // end minor7thFlat5 Chords ================


            if (arr[6].Equals("F") && arr[9].Equals("G#") // minor Chords ============
                    && arr[1].Equals("C")) minorChord += "FG#C ";
            if (arr[10].Equals("A") && arr[1].Equals("C")
                && arr[5].Equals("E")) minorChord += "ACE ";
            i = 0; //restart array
                while (i < 13) 
                {
                    valueTonic = arr[i];
                    if (i + 3 < 13 && arr[i + 3] != "X") minor3rd = arr[i + 3];
                    else if (i + 3 > 13 && arr[i - 9] != "X") minor3rd = arr[i - 9];

                    if (i + 7 < 13 && arr[i + 7] != "X") fifth = arr[i + 7];
                    else if (i + 7 > 13 && arr[i - 5] != "X") fifth = arr[i - 5];

                    if (minor3rd != "X" && fifth != "X" && valueTonic != "X")
                    {
                        minorChord = minorChord + valueTonic + minor3rd + fifth + " ";
                    }
                    valueTonic = "X"; minor3rd = "X"; fifth = "X"; //reset test
                    i++;
                } // end of loop
                OutPutminorChords = minorChord;   // end minor Chords =================

                if (arr[6].Equals("F") && arr[10].Equals("A")  // Major Chords =========
                    && arr[1].Equals("C")) majorChord += "FAC ";
                if (arr[9].Equals("G#") && arr[1].Equals("C") 
                    && arr[4].Equals("D#")) majorChord += "G#CD# ";
            i = 0; //restart array
                while (i < 13)
                {
                    valueTonic = arr[i];
                    if (i + 4 < 13 && arr[i + 4] != "X") major3rd = arr[i + 4];
                    else if (i + 4 > 13 && arr[i - 8] != "X") major3rd = arr[i - 8];

                    if (i + 7 < 13 && arr[i + 7] != "X") fifth = arr[i + 7];
                    else if (i + 7 > 13 && arr[i - 5] != "X") fifth = arr[i - 5];

                    if (major3rd != "X" && fifth != "X" && valueTonic != "X")
                    {
                        majorChord = majorChord + valueTonic + major3rd + fifth + " ";
                    }
                    valueTonic = "X"; major3rd = "X"; fifth = "X"; //reset the test
                    i++;
                }
                OutPutMajorChords = majorChord;
                // end Major Chords

            } //end of Sorted Scale Method. (new chord pattern above) 
        }
    }

