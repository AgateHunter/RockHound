using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RockHound
{
    internal class RockGlossary
    { 

        public string RockComposition { get; set;}

        public string RockTypeDefinition { get; set;}

        
    }

    internal class ClimbGlossary
    {
public string ClimbType {get; set;}

        public string ClimbTypeDefinition {get; set;}
    }

    internal class DifficultyGlossary
    {
public string Difficulty { get; set; }

        public string DifficultyDefinition { get; set; }    
    }
}
