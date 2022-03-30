using Homeworkfour.Business.DTOs;
using Homeworkfour.Business.DTOsFirst.App.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Bussiness.Abstract
{
    public interface IJwtService
    {
        TokenDto Authenticate(UserDto user);
    }

}

