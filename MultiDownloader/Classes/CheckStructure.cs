using CustomAlertBoxDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDownloader.Classes
{
    public class CheckStructure
    { 
        
        string Input { get; set; }
        private List<Regex> Expressions;
        

        public void ApplyRules(List<string> Patterns)
        {
            Expressions = new List<Regex>();
            for (int i = 0; i < Patterns.Count; i++)
            {
                Expressions.Add(new Regex(Patterns[i]));
            }
        }

        public bool Check(string input)
        {
            Input = input;
            bool Status = false;

                for (int i = 0; i < Expressions.Count; i++)
                {
                    if (Expressions[i].IsMatch(Input))
                    {
                        Status = true;
                        break;
                    }
                }
                
            return Status;
        }
        
    }
}
