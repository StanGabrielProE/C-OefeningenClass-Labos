namespace SnelsteAtleet;


    public class Atleet : IComparable<Atleet>
    {
        public string Name { get; set; }
        public byte Time { get; set; }

        public int CompareTo(Atleet? other)
        {
            if (other == null) return 1;
            return this.Time.CompareTo(other.Time); 
        }

        public override string ToString() => $"{Name} {Time} s)";
    }
