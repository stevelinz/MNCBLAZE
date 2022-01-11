using System.Collections.Generic;
using System.IO;
using System.Net;
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

        public string? OutPutData { get; set; }

        static class Again 
        {
           public static string useAgain = "Intialized";
        }
 
        protected override void OnInitialized()
        {
            ScaleList = GetScale();        
        }
        public void ShowSelectedValues()
        {
            OutPutValue = string.Join(" ", SelectedIds.ToArray());
            if (OutPutValue.Equals("")) OutPutValue = "C C# D D# E F F# G G# A A# B";
            Again.useAgain  = OutPutValue;

            string outputString;
 
            outputString = OutPutValue.Trim();
            using StreamWriter noteId = new(Path, append: false);
            noteId.WriteLine(outputString);
            noteId.Close();

            ShowSharp();
            message();
            MustInput();
            ShowC();
            ShowE();
            ShowF();
            ShowG();
            ShowA();
            ShowB();
            ShowD();
 


        }

        public string? SendString()
        {
            return Again.useAgain;
        }

        protected void message()
        {
 
            string sendMessage = "With that Scale, use the NOTE <> CHORD relationship link.";
                OutPutData = sendMessage;   
    
        }

        protected void MustInput()
        {
            if (OutPutValue == "C C# D D# E F F# G G# A A# B")
            {
                OutPutValue = "These notes you can select.";
            }
        }

        protected void ShowC()
        {
            if (OutPutValue == "C ")
            {
                OutPutValue = "Good start you added a C to your scale";
            }
        }
        protected void ShowE()
        {
            if (OutPutValue == "E ")
            {
                OutPutValue = "E the key of Guitar now the rest: G A B D";
            }
        }
        protected void ShowG()
        {
            if (OutPutValue == "G ")
            {
                OutPutValue = "G Major the key of Folk usually";
            }
        }
        protected void ShowF()
        {
            if (OutPutValue == "F ")
            {
                OutPutValue = "F Major just seems darker";
            }
        }
        protected void ShowA()
        {
            if (OutPutValue == "A ")
            {
                OutPutValue = "A Major the key of Ballads, and such.";
            }
        }
        protected void ShowB()
        {
            if (OutPutValue == "B ")
            {
                OutPutValue = "B Major the key for you to decide";
            }
        }
        protected void ShowD()
        {
            if (OutPutValue == "D ")
            {
                OutPutValue = "D Major the key of C&W, seems to me.";
            }
        }
        protected void ShowSharp()
        {
            if (OutPutValue == "C#" || OutPutValue == "D#" || OutPutValue == "F#"
                                    || OutPutValue == "G#" || OutPutValue == "A#")
            {
                OutPutValue = "Sharps also have a flat name C#/Db, D#/Eb, F#/Gb, A#/Bb";
            }
        }

        public List<Scale> GetScale()
        {           
            var C = new Scale()
            {
                NoteId = "C ",
            };
            var CS = new Scale()
            {
                NoteId = "C#",
            };
            var D = new Scale()
            {
                NoteId = "D ",
            };
            var DS = new Scale()
            {
                NoteId = "D#",
            };
            var E = new Scale()
            {
                NoteId = "E ",
            };
            var F = new Scale()
            {
                NoteId = "F ",
            };
            var FS = new Scale()
            {
                NoteId = "F#",
            };
            var G = new Scale()
            {
                NoteId = "G ",
            };
            var GS = new Scale()
            {
                NoteId = "G#",
            };
            var A = new Scale()
            {
                NoteId = "A ",
            };
            var AS = new Scale()
            {
                NoteId = "A#",
            };
            var B = new Scale()
            {
                NoteId = "B ",
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

