using Skeleton.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Repository
{
    public interface IHomeRepository
    {
        IEnumerable<Home> GetData();
    }
}
