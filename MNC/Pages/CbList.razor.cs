using Microsoft.AspNetCore.Components;

namespace BlazorComponents.Pages
{
    public class CbListBase : ComponentBase
    {     
        public List<Scale>? ScaleList { get; set; }
        private const string Path = "notes.txt";
        protected List<string> SelectedIds = new List<string>();
        public List<Scale>? ObjectList { get; set; }

        public string? OutPutValue { get; set; }
        protected override void OnInitialized()
        {
            ScaleList = GetScale();        
        }
        protected void ShowSelectedValues()
        {
            OutPutValue = string.Join(" ", SelectedIds.ToArray()); 
            File.Delete(@"notes.txt");   
            string outputString;
            outputString = OutPutValue.Trim();  
            using StreamWriter noteId = new(Path, append: false);
            noteId.WriteLine(outputString);
            noteId.Close();
            StateHasChanged();
            ShowC();
            ShowE();
            ShowF();
            ShowG();
            ShowA();
            ShowB();
            ShowD();
            ShowSharp();    
        }

        protected void ShowC()
        {
            if (OutPutValue == "C")
            {
                OutPutValue = "Good start you added a C to your scale";
            }
            StateHasChanged();
        }
        protected void ShowE()
        {
            if (OutPutValue == "E")
            {
                OutPutValue = "E the key of Guitar now the rest: G A B D";
            }
            StateHasChanged();
        }
        protected void ShowG()
        {
            if (OutPutValue == "G")
            {
                OutPutValue = "G Major the key of Folk usually";
            }
            StateHasChanged();
        }
        protected void ShowF()
        {
            if (OutPutValue == "F")
            {
                OutPutValue = "F Major just seems darker";
            }
            StateHasChanged();
        }
        protected void ShowA()
        {
            if (OutPutValue == "A")
            {
                OutPutValue = "A Major the key of Ballads, and such.";
            }
            StateHasChanged();
        }
        protected void ShowB()
        {
            if (OutPutValue == "B")
            {
                OutPutValue = "B Major the key for you to decide";
            }
            StateHasChanged();
        }
        protected void ShowD()
        {
            if (OutPutValue == "D")
            {
                OutPutValue = "D Major the key of C&W, seems to me.";
            }
            StateHasChanged();
        }
        protected void ShowSharp()
        {
            if (OutPutValue == "C#" || OutPutValue == "D#" || OutPutValue == "F#"
                || OutPutValue == "G#" || OutPutValue == "A#")
            {
                OutPutValue = "Sharps also have a flat name C#/Db, D#/Eb, F#/Gb, A#/Bb";
            }
            StateHasChanged();
        }

        //public void temp()
        //{

        //}


        public List<Scale> GetScale()
        {           
            var C = new Scale()
            {
                NoteId = "C",              
            };
            var CS = new Scale()
            {
                NoteId = "C#",
            };
            var D = new Scale()
            {
                NoteId = "D",
            };
            var DS = new Scale()
            {
                NoteId = "D#",
            };
            var E = new Scale()
            {
                NoteId = "E",
            };
            var F = new Scale()
            {
                NoteId = "F",
            };
            var FS = new Scale()
            {
                NoteId = "F#",
            };
            var G = new Scale()
            {
                NoteId = "G",
            };
            var GS = new Scale()
            {
                NoteId = "G#",
            };
            var A = new Scale()
            {
                NoteId = "A",
            };
            var AS = new Scale()
            {
                NoteId = "A#",
            };
            var B = new Scale()
            {
                NoteId = "B",
            };

            var vSubList = new List<Scale>
            {
                C, CS, D, DS, E, F, FS, G, GS, A, AS, B
            };

            return vSubList;       
        }
    }

   
   
    public class Scale
    {
        public string? NoteId { get; set; }
    }
}

