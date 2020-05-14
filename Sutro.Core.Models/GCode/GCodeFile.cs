using System.Collections.Generic;

namespace Sutro.Core.Models.GCode
{
    public class GCodeFile
    {
        private readonly List<GCodeLine> lines;

        public GCodeLine this[int i]
        {
            get
            {
                return lines[i];
            }
        }

        public GCodeFile()
        {
            lines = new List<GCodeLine>();
        }

        public void AppendLine(GCodeLine line)
        {
            lines.Add(line);
        }

        public int LineCount
        {
            get { return lines.Count; }
        }

        public IEnumerable<GCodeLine> AllLines()
        {
            int N = lines.Count;
            for (int i = 0; i < N; ++i)
            {
                yield return lines[i];
            }
        }

        public IEnumerable<GCodeLine> AllLinesOfType(LineType eType)
        {
            int N = lines.Count;
            for (int i = 0; i < N; ++i)
            {
                if (lines[i].Type == eType)
                    yield return lines[i];
            }
        }
    }
}