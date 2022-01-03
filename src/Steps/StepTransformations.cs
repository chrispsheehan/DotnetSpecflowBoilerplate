using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Boilerplate.Steps
{
    [Binding]
    public sealed class StepTransformations
    {
        public StepTransformations()
        {

        }

        [StepArgumentTransformation]
        public List<string> TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(',').Select(p => p.Trim()).ToList();
        }                            
    }
}