using System;
using System.Collections.Generic;
using System.Text;
using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        
        IResult Add(Rental rental);
        
    }
}
