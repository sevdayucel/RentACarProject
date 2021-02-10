using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public class IColorDal : IEntityRepository<Color>
    {
        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}