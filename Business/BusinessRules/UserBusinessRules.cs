using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class UserBusinessRules
    {
        private readonly IUserDal _userDal;

        public UserBusinessRules(IUserDal userDal)
        {
            _userDal = userDal;
        }
    }

}
