using Homeworkfour.Business.DTOs;
using Homeworkfour.Business.DTOsFirst.App.Business.DTOs;


namespace Homeworkfour.Bussiness.Abstract
{
    public interface IJwtService
    {
        TokenDto Authenticate(UserDto user);
    }

}

