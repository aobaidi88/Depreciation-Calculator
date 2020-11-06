using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObaidiP4.Shared
{
    public class BaseClass
    {
        
        public DepreciationStraightLine DepreciationStraightLine { get; set; } = new DepreciationStraightLine();
        public DepreciationDoubleDeclining DepreciationDoubleDeclining { get; set; } = new DepreciationDoubleDeclining();
        public string[] DepreciationType { get; set; } = new[] { "Straight Line", "Double Declining" };

        public List<DepreciationStraightLine> depreciationStraights { get; set; } = new List<DepreciationStraightLine>();
    }
}
