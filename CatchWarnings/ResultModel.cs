using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchWarnings
{
    internal class ResultModel
    {
        //public string FilePath { get; set; } = string.Empty;

        //public int LineNumber { get; set; }
        //public string MatchedLine { get; set; } = string.Empty;

        //public string Error { get; set; } = string.Empty;

        public string FileName { get; set; }
        public int LineNumber { get; set; }
        public string LineContent { get; set; }
    }
}
