using DemoDotNETCoreApplication.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace DemoDotNETCoreApplication.Tests
{
    public class ControllerTest
    {
        [Fact]
        public void VerifyIndexViewType()
        {
         var controller=  new HomeController();
         var result= controller.Index();
         Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void VerifyAboutViewType()
        {
            var controller = new HomeController();
            var result = controller.About();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void VerifyContactViewType()
        {
            var controller = new HomeController();
            var result = controller.Contact();
            Assert.IsType<ViewResult>(result);
        }
    }
}
