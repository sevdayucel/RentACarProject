using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal brandDal)
        {
            _colorDal = brandDal;
        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p=>p.ColorId==colorId));
            
        }
    }
}