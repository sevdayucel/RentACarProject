using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            if (user.FirstName == null || user.LastName == null || user.Password == null || user.Email == null)
            {
                Console.WriteLine("Lütfen bilgileri kontrol edin");
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdd);

        }
        public IDataResult<List<User>> GetAll()
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }


    }
}
