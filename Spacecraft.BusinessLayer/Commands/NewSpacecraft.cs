namespace Spacecraft.BusinessLayer.Commands
{
    internal class NewSpacecraft : ICommand
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int CapacityInPounds { get; set; }

        public Color Color { get; set; }

        public int Rating { get; set; }

        public bool IsTimemachine { get; set; }
    }

    public enum Color
    {
        Black,
        Gray,
        Blue,
        Brown
    }
}
