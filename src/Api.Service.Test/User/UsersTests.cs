using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;

namespace Api.Service.Test.User
{
    public class UsersTests
    {
        public static string UserName { get; set; }
        public static string UserEmail { get; set; }
        public static string UserNameUpdated { get; set; }
        public static string UserEmailUpdated { get; set; }
        public static Guid UserId { get; set; }

        public List<UserDto> UserList = new List<UserDto>();
        public UserDto userDto = new UserDto();
        public UserDtoCreateResult userDtoCreate = new UserDtoCreateResult();
        public UserDtoUpdateResult userDtoUpdateResult = new UserDtoUpdateResult();

        public UsersTests()
        {
            UserId = Guid.NewGuid();
            UserName = Faker.Name.FullName();
            UserEmail = Faker.Internet.Email();
            UserNameUpdated = Faker.Name.First();
            UserEmailUpdated = Faker.Internet.Email();

            for (int i = 0; i < 10; i++)
            {

            }
        }



    }
}