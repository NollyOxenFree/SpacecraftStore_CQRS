using SpacecraftStoreManager.Contracts;

namespace SpacecraftStoreManager
{
    public class SpacecraftFeaturedManager
    {
        public SpacecraftFeaturedManager()
        {
        }

        public Spacecraft GetFeaturedSpacecraft()
        {
            return new Spacecraft
            {
                Price = 10000,
                Date = DateTime.Now,
                Name = "Serentiy"
            };
        }
    }
}