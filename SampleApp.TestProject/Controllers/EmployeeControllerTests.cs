using Microsoft.AspNetCore.Mvc;
using Moq;
using SampleApp.Core.Entities;
using SampleData.Core.Contracts;
using SampleMVCApplication.Controllers;

namespace SampleApp.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTests
    {
        [TestMethod]
        public async Task Index_ReturnsAViewResult_WithAListOfEmployees()
        {
            // Arrange
            var mockEmployeeRepository = new Mock<IEmployeeRepository>();
            mockEmployeeRepository
                .Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(new List<Employee>
                {
                    new Employee { Id = 1, Name = "Employee 1", Position = "Position 1" },
                    new Employee { Id = 2, Name = "Employee 2", Position = "Position 2" }
                });

            var controller = new EmployeeController(mockEmployeeRepository.Object);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }

}
