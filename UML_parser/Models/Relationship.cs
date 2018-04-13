namespace Models
{
    public class Relationship
    {
        public string Type { get; set; }
        public int Cardinality { get; set; }
        public Class Class { get; set; }

        public Relationship(string type, string cardinality, Class Class)
        {
            Type = type;
            Cardinality = Cardinality;
            this.Class = Class;
        }
    }
}
