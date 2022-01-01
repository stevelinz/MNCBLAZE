
namespace BlazorComponents.Pages
{
    public class ScaleConvert
    {

        public void convertScale()
        {
            string noteInput = File.ReadAllText(@"notes.txt");

            StreamWriter scaleNumbers = new(@"scaleConvert.txt", append: false);

            int[] scaleArray = new int[24];

            if (noteInput.Contains("C"))
            {
                scaleArray[0] = 1;
                scaleArray[12] = 13;
            }
            if (noteInput.Contains("C#"))
            {
                scaleArray[1] = 2;
                scaleArray[13] = 14;
            }
            if (noteInput.Contains("D"))
            {
                scaleArray[2] = 3;
                scaleArray[14] = 15;
            }
            if (noteInput.Contains("D#"))
            {
                scaleArray[3] = 4;
                scaleArray[15] = 16;
            }
            if (noteInput.Contains("E"))
            {
                scaleArray[4] = 5;
                scaleArray[16] = 17;
            }
            if (noteInput.Contains("F"))
            {
                scaleArray[5] = 6;
                scaleArray[17] = 18;
            }
            if (noteInput.Contains("F#"))
            {
                scaleArray[6] = 7;
                scaleArray[18] = 19;
            }
            if (noteInput.Contains("G"))
            {
                scaleArray[7] = 8;
                scaleArray[19] = 20;
            }
            if (noteInput.Contains("G#"))
            {
                scaleArray[8] = 9;
                scaleArray[20] = 21;
            }
            if (noteInput.Contains("A"))
            {
                scaleArray[9] = 10;
                scaleArray[21] = 22;
            }
            if (noteInput.Contains("A#"))
            {
                scaleArray[10] = 11;
                scaleArray[22] = 23;
            }
            if (noteInput.Contains("B"))
            {
                scaleArray[11] = 12;
                scaleArray[23] = 24;
            }

            foreach (var item in scaleArray)
            {
                scaleNumbers.WriteLine(item + " ");
            }

            scaleNumbers.Close();

        }

    }
 }

