﻿using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        
        IResult Add(User users);
        IDataResult<List<User>> GetAll();

    }
}
