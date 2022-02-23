namespace Patterns.HeadFirst.Builder
{
    public class ComplexObjectBuilder
    {
        private readonly ComplexObject _complexObject;

        public ComplexObjectBuilder(string name)
        {
            _complexObject = new ComplexObject(name);
        }

        public ComplexObjectBuilder WithCreator(string creatorName)
        {
            _complexObject.Creator = creatorName;
            return this;
        }

        public ComplexObjectBuilder WithExpiration(DateTime exp)
        {
            _complexObject.Expiration = exp;
            return this;
        }

        public ComplexObjectBuilder WithDetails()
        {
            _complexObject.Details = new Dictionary<string, string>()
            {
                { "Type", "My object"}
            };

            return this;
        }

        public ComplexObject Build() => _complexObject;
    }
}