using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelLearning.Properties
{
    internal class CountSpacesResult
    {
        public string FileName { get; set; }
        public int SpacesCount { get; set; }
        public CountSpacesResult(string FileName, int SpacesCount)
        {
            this.FileName = FileName;
            this.SpacesCount = SpacesCount;
        }
    }
}
