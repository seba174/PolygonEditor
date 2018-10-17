
namespace PolygonEditor
{
    public class EdgeType
    {
        private readonly int value;

        public string Name { get; private set; }

        public static EdgeType Vertical = new EdgeType(0, nameof(Vertical));
        public static EdgeType Horizontal = new EdgeType(1, nameof(Horizontal));
        public static EdgeType FixedLength = new EdgeType(2, nameof(FixedLength));
        public static EdgeType Normal = new EdgeType(3, nameof(Normal));

        public bool Equals(EdgeType other)
        {
            return other is null ? false : value == other.value;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals(obj as EdgeType);
        }

        public override int GetHashCode() => value.GetHashCode();

        private EdgeType() { }

        private EdgeType(int value, string Name)
        {
            this.value = value;
            this.Name = Name;
        }
    }
}
