namespace Sutro.Core.Models.GCode
{
    public enum LineType
    {
        GCode,
        MCode,
        UnknownCode,

        Comment,
        UnknownString,
        Blank,

        If,
        EndIf,
        Else,
        UnknownControl
    }
}