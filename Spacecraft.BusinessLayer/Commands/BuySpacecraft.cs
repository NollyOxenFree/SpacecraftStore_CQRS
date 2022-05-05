namespace Spacecraft.BusinessLayer.Commands
{
    public class BuySpacecraft : ICommand
    {
        public BuySpacecraft(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
