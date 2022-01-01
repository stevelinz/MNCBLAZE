using Microsoft.AspNetCore.Components;

namespace BlazorComponents.Pages
{
    public class LogicBase : ComponentBase
    {
        public string? OutPutScale { get; set; }
        public string? OutPutLogic { get; set; }

 
        ScaleConvert scaleConvert = new ScaleConvert();
    
        protected void test()
        {
            scaleConvert.convertScale();

            OutPutScale = File.ReadAllText(@"notes.txt");

            OutPutLogic = File.ReadAllText(@"scaleConvert.txt");



        }

      
    }
}
