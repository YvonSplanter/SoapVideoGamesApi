using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoapVideoApi.Model
{
    public class CatalogVideo
    {
        public List<Video> Video { get; set; }

        public CatalogVideo()
        {
            this.Video = new List<Video>();
        }
    }
}
