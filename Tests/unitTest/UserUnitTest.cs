﻿using NUnit.Framework;
using userMicroservice.Data;
using userMicroservice.Model;
using userMicroservice.Tests.Common;
using userMicroservice.Tests.Common.ScenarioDatas;

namespace userMicroservice.Tests.unitTest
{
    public class UserUnitTest : TestBase
    {
        private DbContextClass _dbContextClass;

        [SetUp]
        public void Setup()
        {
            SetupTest();

            DbContextClass? dbContextClass = _serviceProvider.GetService<DbContextClass>();
            _dbContextClass = dbContextClass!;

            _dbContextClass.CreateUser();
        }

        [TearDown]
        public void Teardown()
        {
            CleanTest();
        }

        [Test]
        public async Task CreateUser()
        {
            // Arrange
            var user = new User()
            {
                UserId = 3,
                UserName = "JohannaDoe",
                Address = "56 cours franklin roosevelt 69120 Vaulx-en-velin"
            };

            // Act
            var userToAdd = await _dbContextClass.Users.AddAsync(user).ConfigureAwait(false);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(userToAdd, Is.Not.Null);
                Assert.That(user.UserName, Is.EqualTo("JohannaDoe"));
            });
        }
    }
}
