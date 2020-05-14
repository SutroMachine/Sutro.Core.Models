namespace Sutro.Core.Models.GCode
{
    public struct GCodeParam
	{
		public enum PType
		{
			Code,
			DoubleValue,
			IntegerValue,
			TextValue,
			NoValue,
			Unknown
		}

		public PType type;
		public string identifier;

		public double doubleValue;      
		public int intValue {
			get { return (int)doubleValue; }    // we can store [-2^54, 2^54] precisely in a double
			set { doubleValue = value; }
		}
		public string textValue;
	}
}