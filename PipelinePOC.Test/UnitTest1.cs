using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PipelinePOC.Controllers;
using System;
using Xunit;

namespace PipelinePOC.Test
{
    public class ControllerTest
    {
        private readonly ILogger<HomeController> _logger;
        [Fact]
        public void Test_home_controller_index()
        {
            
            HomeController controller = new HomeController(_logger);
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);

        }
        public void Test_Index_Return_Result()
        {
            //Arrange
            var controller = new HomeController(_logger);
            //Act
            var result = controller.Index();
            //Assert
            Assert.NotNull(result);
        }
    }
}
