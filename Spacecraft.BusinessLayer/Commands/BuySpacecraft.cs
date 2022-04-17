namespace Spacecraft.BusinessLayer.Commands
{
    internal class BuySpacecraft : ICommand
    {
        public BuySpacecraft(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
