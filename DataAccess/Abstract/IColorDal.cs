using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
        
        
    }
}