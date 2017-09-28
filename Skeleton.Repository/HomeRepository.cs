
using Skeleton.Common.DataAccess.Repository;
using Skeleton.Common.DataAccess.UnitOfWork;
using Skeleton.Models.Entity;
using Skeleton.Repository.SkeletonContextPartial;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Repository
{
    public class HomeRepository : Repository<Home>, IHomeRepository
    {
        SkeletonDBContext UOWContext;
        public HomeRepository(IUnitOfWork okITUOW) : base(okITUOW)
        {
            UOWContext = ((SkeletonDBContext)UOW.Context);
        }

        public IEnumerable<Home> GetData()
        {
            
            //Add(new Home { HomeText = "test" }); //for testing purspose

            //UOWContext.SaveChanges(); //for testing purpose

            var result = GetAll();
            return result;
        }

        #region ViewModelExposing

        #endregion ViewModelExposing
    }
}
