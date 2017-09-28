
using Skeleton.Models.DTO;
using Skeleton.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Skeleton.Service
{
    public class HomeService : IHomeService
    {
        public IHomeRepository _homeRepository;
        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public IEnumerable<HomeViewModel> GetData()
        {
            var result = _homeRepository.GetData().Select(HomeViewModel.ToViewModel)?.ToList().OrderBy(x=>x.HomeId);
            return result;
        }
    }
}
