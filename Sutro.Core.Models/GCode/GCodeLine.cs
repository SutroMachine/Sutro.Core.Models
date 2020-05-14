namespace Sutro.Core.Models.GCode
{
    // ugh..class...dangerous!!
    public class GCodeLine
    {
        public int LineNumber { get; set; }

        public LineType Type { get; set; }

        public string OriginalString { get; set; }

        // N number of line
        public int N;

        // G or M code
        public int Code { get; set; }

        // arguments/parameters
        public GCodeParam[] Parameters { get; set; }

        public string Comment { get; set; }

        public GCodeLine(int lineNumber, LineType type)
        {
            LineNumber = lineNumber;
            Type = type;

            OriginalString = null;
            N = Code = -1;
            Parameters = null;
            Comment = null;
        }

        public GCodeLine(int lineNumber, LineType type, string comment)
        {
            LineNumber = lineNumber;
            Type = type;
            if (type == LineType.UnknownString)
            {
                OriginalString = comment;
            }
            else
            {
                Comment = comment;
            }
        }

        public virtual GCodeLine Clone()
        {
            GCodeLine clone = new GCodeLine(LineNumber, Type);
            clone.OriginalString = OriginalString;
            clone.N = N;
            clone.Code = Code;
            if (Parameters != null)
            {
                clone.Parameters = new GCodeParam[Parameters.Length];
                for (int i = 0; i < Parameters.Length; ++i)
                {
                    clone.Parameters[i] = Parameters[i];
                }
            }
            clone.Comment = Comment;
            return clone;
        }
    }
}