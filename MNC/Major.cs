using Microsoft.AspNetCore.Components;

namespace BlazorComponents.Pages 
{
    public class Major : ComponentBase
    {
   
        public string workingArray()
        {
           CbListBase cbListBase = new CbListBase();
         return cbListBase.SendString();
            

        }
        
    }
}
