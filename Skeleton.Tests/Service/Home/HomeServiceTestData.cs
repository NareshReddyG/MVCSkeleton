using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Skeleton.Tests.Service
{
    public class HomeServiceTestData
    {
        public IEnumerable<Skeleton.Models.Entity.Home> GetAllTestData()
        {
            return new List<Skeleton.Models.Entity.Home>
            {
                new Skeleton.Models.Entity.Home
                {
                    HomeId = 1,
                    HomeText = "HomTextTestData"
                }
            };
        }
    }
}
