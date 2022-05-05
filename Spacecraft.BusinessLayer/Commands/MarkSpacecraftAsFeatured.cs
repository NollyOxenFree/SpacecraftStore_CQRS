namespace Spacecraft.BusinessLayer.Commands
{
    public class MarkSpacecraftAsFeatured : ICommand
    {
        public MarkSpacecraftAsFeatured(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
