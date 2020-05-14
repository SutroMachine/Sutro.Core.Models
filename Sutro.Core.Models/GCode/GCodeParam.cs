namespace Sutro.Core.Models.GCode
{
    public readonly struct GCodeParam
    {
        public static GCodeParam Integer(int value, string identifier)
        {
            return new GCodeParam(GCodeParamTypes.IntegerValue, identifier, value, default);
        }

        public static GCodeParam Double(double value, string identifier)
        {
            return new GCodeParam(GCodeParamTypes.DoubleValue, identifier, value, default);
        }

        public static GCodeParam Text(string value, string identifier = default)
        {
            return new GCodeParam(GCodeParamTypes.TextValue, identifier, default, value);
        }

        public static GCodeParam NoValue(string identifier)
        {
            return new GCodeParam(GCodeParamTypes.NoValue, identifier, default, default);
        }

        private GCodeParam(GCodeParamTypes type, string identifier, double numericalValue, string textValue)
        {
            Type = type;
            Identifier = identifier;
            DoubleValue = numericalValue;
            TextValue = textValue;
        }

        public GCodeParamTypes Type { get; }
        public string Identifier { get; }

        public double DoubleValue { get; }

        // we can store [-2^54, 2^54] precisely in a double
        public int IntegerValue
        {
            get { return (int)DoubleValue; }
        }

        public string TextValue { get; }
    }
}