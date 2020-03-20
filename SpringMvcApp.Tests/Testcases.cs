using Dapper;
using Moq;
using NSubstitute;
using SpringMvcApp.BusinessLayer.Interfaces;
using SpringMvcApp.BusinessLayer.Services;
using SpringMvcApp.BusinessLayer.Services.Repository;
using SpringMvcApp.DataLeyer;
using SpringMvcApp.Entities;
using SpringMvcApp.Tests.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace SpringMvcApp.Tests
{
 public class Testcases
    {
       
        private IUserServices _services;
        private IAdminServices _adminservices;

        public readonly Mock<IUserRepository> service = new Mock<IUserRepository>();
        public readonly Mock<IAdminRepository> services = new Mock<IAdminRepository>();

        public Testcases()
        {
            _services = new UserServices(service.Object);
            _adminservices = new AdminServices(services.Object);

        }
        Random random = new Random();

        [Fact]
        public async Task TestFor_ValidUserRegistrationAsync()
        {
            Random random = new Random();
            
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "Rose",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "abc@gmail.com",
                Photo = "Phot.jpeg"
            };
          
            service.Setup(repos => repos.RegisterAsync(user)).ReturnsAsync(user);
            var registeredUser = await _services.RegisterAsync(user);
            Assert.Equal(user, registeredUser);
        }


        [Fact]
        public async Task Testfor_ValidSignin()
        {

            Random random = new Random();

            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "Rose",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "abc@gmail.com",
                Photo = "Phot.jpeg"
            };
            service.Setup(repos => repos.Signin(user.UserName, user.Password)).ReturnsAsync(user.Id); 
            var register =await _services.Signin(user.UserName, user.Password);

            Assert.Equal(user.Id.ToString(),register.ToString()); ;
        }

        [Fact]
        public async Task Testfor_AllUser()
        {
            //Action
            service.Setup(repos => repos.GetAllUserAsync());
            var register = await _services.GetAllUserAsync();
            //Assertion
            Assert.NotNull(register);
           // Assert.NotEmpty(register);
        }
        [Fact]
        public async Task Testfor_GetUser()
        {
            //Action
            Random random = new Random();

            var user = new User()
            {
                Id =35,
                UserName = "Rose",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "abc@gmail.com",
                Photo = "Phot.jpeg"
            };

            service.Setup(repos => repos.GetUser(user.Id)).ReturnsAsync(user);
            var register = await _services.GetUser(user.Id);
            //Assertion
            Assert.Equal(user,register);
            // Assert.NotEmpty(register);
        }

        [Fact]
        public void Boundary_Testfor_ValidId()
        {
            //Action
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "Rose",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "abc@gmail.com",
                Photo = "Phot.jpeg"
            };
            //Assert
            Assert.InRange(user.Id, 35, 300000);

        }

        [Fact]
        public void Boundary_Testfor_ValidPassword()
        {
            //Action
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "Rose",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "abc@gmail.com",
                Photo = "Phot.jpeg"
            };
            //Assert
            Assert.InRange(user.Password.Length, 4, 20);
        }

        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "Rose",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "abc@gmail.com",
                Photo = "Phot.jpeg"
            };
           
            bool isEmail = Regex.IsMatch(user.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public async void ExceptionTestForUserNotFound()
        {

            //Arrange
            User user = new User()
            {
                Id = -12,
                UserName = "gg",
                Password = "1234",
                ConfirmPassword = "1234",
                Email = "Ss@gmail.com",
                Photo = "fff"

            };
          Assert.ThrowsAsync<UserNotFoundExceptions>(async () => await _services.GetUser(user.Id));
        }


        [Fact]
        public async Task Test_For_DeleteUser()
        {
            User user = new User()
            {
                Id = 1,
            };

            services.Setup(repos => repos.DeleteUserAsync(user.Id)).ReturnsAsync(user);

            var register = await _adminservices.DeleteUserAsync(user.Id);

            Assert.Equal(user, register);
        }


        [Fact]
        public async Task Test_For_UpadateUser()
        {
            User user = new User()
            {
                Id = 1,
            };

            services.Setup(repos => repos.UpdateUserAsync(user)).ReturnsAsync(true);

            var isUpdated = await _adminservices.UpdateUserAsync(user);

            Assert.True(isUpdated);
        }

    }
}
