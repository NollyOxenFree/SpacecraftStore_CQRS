namespace Spacecraft.BusinessLayer.Queries
{
    public class SpacecraftQueryHandler : IQueryHandler<SpacecraftInventory>, IQueryHandler<FeaturedSpacecraftDetails>
    {
        public void Handle(SpacecraftInventory query)
        {
            // use Id from query to select inventory from tables
        }

        public void Handle(FeaturedSpacecraftDetails query)
        {
            // use id from query to get specific details on spacecraft to show in featured list
        }
    }
}
