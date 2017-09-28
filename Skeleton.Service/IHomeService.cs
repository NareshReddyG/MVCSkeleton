using Skeleton.Models.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Service
{
    public interface IHomeService 
    {
        IEnumerable<HomeViewModel> GetData();
    }
}
