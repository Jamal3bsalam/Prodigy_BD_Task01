using PRODIGY_Task01.Models.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodigy_Task01.Service.Services
{
    public class UserService
    {
        private Dictionary<string,UserDto> UserData = new Dictionary<string, UserDto>();  
        public UserDto CreateUser(UserDto user)
        {
            if (user is null) return null;
            UserData.Add(user.Id,user);
            user.Id = Guid.NewGuid().ToString() + user.Id;
            return user;
        }

        public UserDto UpdateUser(string id,UpdateUserDto updateUserDto)
        {
            if (!UserData.ContainsKey(id)) return null;

            var user = UserData[id];
            user.Name = updateUserDto.Name;
            user.Email = updateUserDto.Email;
            user.Age = updateUserDto.Age;

            return user;
        }

        public UserDto GetUser(string id)
        {
            if (!UserData.ContainsKey(id)) return null;
            var user = UserData[id];
            if(user is null) return null;
            return user;
        }

        public string DeleteUser(string id)
        {
            if (!UserData.ContainsKey(id)) return null;
            UserData.Remove(id);
            return "User Deleted Succesfully";
        }
    }
}
