using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Services.AuthAPI.Data;
using ShoppingApp.Services.AuthAPI.Models;
using ShoppingApp.Services.AuthAPI.Models.Dto;

namespace ShoppingApp.Services.AuthAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public UserAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<User> objList = _db.Users.ToList();
                _response.Result = _mapper.Map<IEnumerable<UserDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                User obj = _db.Users.First(u => u.UserId == id);
                _response.Result = _mapper.Map<UserDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
