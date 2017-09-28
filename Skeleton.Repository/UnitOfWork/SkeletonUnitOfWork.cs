using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Repository.UOW
{
    public class OkItUnitOfWork : Common.DataAccess.UnitOfWork.UnitOfWork, IDisposable
    {        
        public OkItUnitOfWork() : this(new SkeletonContextPartial.SkeletonDBContext())
        {

        }
        public OkItUnitOfWork(System.Data.Entity.DbContext context) : base(context)
        {
            if (context == null)
            {
                context = new Skeleton.Repository.SkeletonContextPartial.SkeletonDBContext();
            }
        }

    }
}
