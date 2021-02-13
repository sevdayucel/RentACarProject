﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.CustomerId == 0)
            {
                return new ErrorResult(Messages.RentalNotAdd);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdd);
        }

        
    }
}
