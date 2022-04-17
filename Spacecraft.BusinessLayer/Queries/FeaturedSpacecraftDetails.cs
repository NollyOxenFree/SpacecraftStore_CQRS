using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacecraft.BusinessLayer.Queries
{
    public class FeaturedSpacecraftDetails : IQuery
    {
        public FeaturedSpacecraftDetails(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public string TopReviewContent { get; set; }

        public Image[]  FeaturedImages { get; set; }
    }
    
    internal class Image
    {
    }
}
