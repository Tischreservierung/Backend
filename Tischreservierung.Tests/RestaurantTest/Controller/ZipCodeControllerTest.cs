﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using Tischreservierung.Controllers;
using Core.Models;
using Core.Contracts;
using Microsoft.AspNetCore.Http;

namespace Tischreservierung.Tests.RestaurantTest.Controller
{
    public class ZipCodeControllerTest
    {
        [Fact]
        public async Task GetAllRestaurants()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.ZipCodes.GetAll()).ReturnsAsync(GetZipCodeTestData());
            var controller = new ZipCodesController(uow.Object);

            var actionResult = await controller.GetZipCodes();
            var result = actionResult.Result as ObjectResult;


            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(4, (result.Value as IEnumerable<ZipCode>)!.Count());

            uow.Verify(x => x.ZipCodes.GetAll());
            uow.VerifyNoOtherCalls();
        }

        private static List<ZipCode> GetZipCodeTestData()
        {
            List<ZipCode> zipCodes = new()
            {
                new ZipCode() { ZipCodeNr = "4470", District = "Linz-Land", Location = "Enns" },
                new ZipCode() { ZipCodeNr = "4020", District = "Linz", Location = "Linz" },
                new ZipCode() { ZipCodeNr = "4030", District = "Linz", Location = "Linz" },
                new ZipCode() { ZipCodeNr = "4460", District = "Linz-Land", Location = "Leonding" }
            };
            return zipCodes;
        }
    }
}
