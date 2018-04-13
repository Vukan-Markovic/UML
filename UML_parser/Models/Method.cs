namespace Models
{
    public class Method
    {
        public string Accessor { get; set; }
        public string Name { get; set; }

        public Method(string accessor, string name)
        {
            Accessor = accessor;
            Name = name;
        }
    }
}
