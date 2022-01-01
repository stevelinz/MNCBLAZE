using Microsoft.AspNetCore.Components;


namespace BlazorComponents.Pages
    {
        public class ChordLogicBase : ComponentBase
       
    {
         
        public string? OutPutChordLogic { get; set; }

        public int[] scaleArray = new int[80];
        public int start = 0;
        public int count = 0;

        protected void Test()
        {
            string chordFound = showArray();

            OutPutChordLogic = chordFound;

         // Major major = new Major();
         //string sendNotes =    major.workingArray();


         //   OutPutChordLogic = sendNotes;
        }

        public  void noteToNumber()
        {
            //  Array.Clear(scaleArray, 0, scaleArray.Length);


            //  string tempOriginal = File.ReadAllText(@"notes.txt");

            //  List<string> tempOriginal = file.ReadAllText(@"notes.txt").ToList();


            string temp = "";

            //string first = (File.ReadAllText((string)@"notes.txt").Split((char)' ')
            //                 .FirstOrDefault(w => (bool)Enumerable.Any<string>(File.ReadAllText((string)@"notes.txt"), (Func<string, bool>)(m => (bool)w.Contains((string)m)))) ?? string.Empty).Trim();

            string rcs = "", tds = "", yfs = "", ugs = "", ias = "",
                   ccc = "", ddd = "", eee = "", fff = "", ggg = "",
                   aaa = "", bbb = "";

            //if (first.Equals(ccc)) start = 1;
            //if (first.Equals(rcs)) start = 2;
            //if (first.Equals(ddd)) start = 3;
            //if (first.Equals(tds)) start = 4;
            //if (first.Equals(eee)) start = 5;
            //if (first.Equals(fff)) start = 6;
            //if (first.Equals(yfs)) start = 7;
            //if (first.Equals(ggg)) start = 8;
            //if (first.Equals(ugs)) start = 9;
            //if (first.Equals(aaa)) start = 10;
            //if (first.Equals(ias)) start = 11;
            //if (first.Equals(bbb)) start = 12;


            foreach (var item in File.ReadAllText(@"notes.txt"))
            {
                temp = item.ToString();


                if (temp.Contains("C#")) rcs = temp.Replace("C#", "R");
                if (temp.Contains("D#")) tds = temp.Replace("D#", "T");
                if (temp.Contains("F#")) yfs = temp.Replace("F#", "Y");
                if (temp.Contains("G#")) ugs = temp.Replace("G#", "U");
                if (temp.Contains("A#")) ias = temp.Replace("A#", "I");
                if (temp.Contains("C"))  ccc = temp.Replace("C", "C");
                if (temp.Contains("D"))  ddd = temp.Replace("D", "D");
                if (temp.Contains("E"))  eee = temp.Replace("E", "E");
                if (temp.Contains("F"))  fff = temp.Replace("F", "F");
                if (temp.Contains("G"))  ggg = temp.Replace("G", "G");
                if (temp.Contains("A"))  aaa = temp.Replace("A", "A");
                if (temp.Contains("B"))  bbb = temp.Replace("B", "B");



                if (temp.Contains(ccc))
                {
                    scaleArray[1] = 1;
                    scaleArray[13] = 13;
                    scaleArray[25] = 25;
                }
                if (temp.Contains(rcs))
                {
                    scaleArray[2] = 2;
                    scaleArray[14] = 14;
                    scaleArray[26] = 26;
                }
                if (temp.Contains(ddd))
                {
                    scaleArray[3] = 3;
                    scaleArray[15] = 15;
                    scaleArray[27] = 27;
                }
                if (temp.Contains(tds))
                {
                    scaleArray[4] = 4;
                    scaleArray[16] = 16;
                    scaleArray[28] = 28;
                }

                if (temp.Contains(eee))
                {
                    scaleArray[5] = 5;
                    scaleArray[17] = 17;
                    scaleArray[29] = 29;
                }

                if (temp.Contains(fff))
                {
                    scaleArray[6] = 6;
                    scaleArray[18] = 18;
                    scaleArray[30] = 30;
                }
                if (temp.Contains(yfs))
                {
                    scaleArray[7] = 7;
                    scaleArray[19] = 19;
                    scaleArray[31] = 31;
                }
                if (temp.Contains(ggg))
                {
                    scaleArray[8] = 8;
                    scaleArray[20] = 20;
                    scaleArray[32] = 32;
                }
                if (temp.Contains(ugs))
                {
                    scaleArray[9] = 9;
                    scaleArray[21] = 21;
                    scaleArray[33] = 33;
                }
                if (temp.Contains(aaa))
                {
                    scaleArray[10] = 10;
                    scaleArray[22] = 22;
                    scaleArray[34] = 34;
                }
                if (temp.Contains(ias))
                {
                    scaleArray[11] = 11;
                    scaleArray[23] = 23;
                    scaleArray[35] = 35;
                }
                if (temp.Contains(bbb))
                {
                    scaleArray[12] = 12;
                    scaleArray[24] = 24;
                    scaleArray[36] = 36;
                }            
            }
        }
        public string showArray()
            {
            string[] numbersToNote =
            {" ","C","C#","D","D#","E","F","F#","G","G#","A","A#","B",
                 "C","C#","D","D#","E","F","F#","G","G#","A","A#","B",
                 "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};

            string found = "Major: ";

            
            noteToNumber();

           
          
            int x = start;
            int count = 0; 
                while (count <= 24)
                {
                if (scaleArray[x] == 0)
                {
                    x++;
                    count++;
                    continue;
                }                 
                if ((scaleArray[x + 4] != 0) && (scaleArray[x + 7] != 0))
                    {
                        found = found + "___" + numbersToNote[x] + " " +
                        numbersToNote[x + 4] + " " + numbersToNote[x + 7] + "___";
                    }
                count++;
                x++;              

            }
                return found;  
            }

        }
    }

