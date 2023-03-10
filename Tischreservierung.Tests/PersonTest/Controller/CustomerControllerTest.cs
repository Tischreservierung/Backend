using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tischreservierung.Controllers;
using Tischreservierung.Controllers.Person;
using Persistence.Data;
using Persistence.Data.Person;
using Core.Contracts;
using Core.Models.Person;
using Xunit.Sdk;

namespace Tischreservierung.Tests.Person.Controller
{
    public class CustomerControllerTest
    {
        [Fact]
        public async Task GetAllCustomers()
        {
            var customerRepo = new Mock<ICustomerRepository>();
            customerRepo.Setup(d => d.GetCustomers()).ReturnsAsync(TestData());
            var customerCont = new CustomerController(customerRepo.Object);

            var actionResult = await customerCont.GetCustomers();

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result!.StatusCode);
            Assert.Equal(4, ((List<Customer>)result.Value!).Count());

            customerRepo.Verify(c => c.GetCustomers());
            customerRepo.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetCorrectCustomerByMail()
        {
            string mail = "witz@gmail.com";

            var customerRepo = new Mock<ICustomerRepository>();
            customerRepo.Setup(d => d.GetCustomerByEMail(mail)).ReturnsAsync(TestData()[3]);
            var customerCont = new CustomerController(customerRepo.Object);

            var actionResult = await customerCont.GetCustomerByMail(mail);

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;


            Assert.NotNull(result);
            Assert.Equal(200, result!.StatusCode);
            Assert.Equal("testDataD", ((Customer)result.Value!).CustomerNumber);
        }

        [Fact]
        public void CreateNewCustomer()
        {
            Customer customer = new Customer()
            {
                Id = 10,
                Name = "Sepp",
                FamilyName = "Apfel",
                EMail = "birnenseppl@gmail.com",
                Password = "testF",
                CustomerNumber = "testDataF"
            };

            var customerRepo = new Mock<ICustomerRepository>();
            customerRepo.Setup(d => d.SetCustomer(customer)).Returns(true);
            var customerCont = new CustomerController(customerRepo.Object);

            var actionResult = customerCont.PostCustomer(customer);

            Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            var result = actionResult.Result as CreatedAtActionResult;

            Assert.NotNull(result);
            Assert.Equal(201, result!.StatusCode);
            Assert.Equal(customer, result.Value as Customer);

            customerRepo.Verify(c => c.SetCustomer(customer));
            customerRepo.Verify(c => c.Save());
            customerRepo.VerifyNoOtherCalls();
        }

        [Fact]
        public void CreateCustomerWithAlreadyExistingMail()
        {
            Customer customer = new Customer()
            {
                Id = 10,
                Name = "Sepp",
                FamilyName = "Apfel",
                EMail = "markus@gmail.com",
                Password = "testF",
                CustomerNumber = "testDataF"
            };

            var customerRepo = new Mock<ICustomerRepository>();
            var customerCont = new CustomerController(customerRepo.Object);

            customerRepo.Setup(d => d.SetCustomer(customer)).Returns(true);
            var actionResult1 = customerCont.PostCustomer(customer);

            customerRepo.Setup(d => d.SetCustomer(customer)).Returns(false);
            var actionResult2 = customerCont.PostCustomer(customer);

            Assert.IsType<UnprocessableEntityObjectResult>(actionResult2.Result);
            var result = actionResult2.Result as UnprocessableEntityObjectResult;

            Assert.NotNull(result);
            Assert.Equal(422, result!.StatusCode);

            customerRepo.Verify(c => c.SetCustomer(customer));
            customerRepo.Verify(c => c.Save());
            customerRepo.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task DeleteCustomer()
        {
            string mail = "witz@gmail.com";

            var customerRepo = new Mock<ICustomerRepository>();

            customerRepo.Setup(r => r.GetCustomerByEMail(mail)).ReturnsAsync(new Customer());
            customerRepo.Setup(r => r.DeleteCustomer(It.IsAny<Customer>()));
            var customerCont = new CustomerController(customerRepo.Object);

            var actionResult = await customerCont.DeleteCustomer(mail);

            Assert.IsType<NoContentResult>(actionResult);

            customerRepo.Verify(r => r.GetCustomerByEMail(mail));
            customerRepo.Verify(r => r.DeleteCustomer(It.IsAny<Customer>()));
            customerRepo.Verify(r => r.Save());
            customerRepo.VerifyNoOtherCalls();
        }


        private static List<Customer> TestData()
        {
            List<Customer> data = new List<Customer>();

            data.Add(new Customer()
            {
                Id = 1,
                Name = "Markus",
                FamilyName = "Witz",
                EMail = "markus@gmail.com",
                Password = "testA",
                CustomerNumber = "testDataA"
            });
            data.Add(new Customer()
            {
                Id = 2,
                Name = "Hermann",
                FamilyName = "Bauer",
                EMail = "h.bauer@gmail.com",
                Password = "testB",
                CustomerNumber = "testDataB"
            });
            data.Add(new Customer()
            {
                Id = 3,
                Name = "Sebastian",
                FamilyName = "Witzeneder",
                EMail = "funnymail@gmx.at",
                Password = "testC",
                CustomerNumber = "testDataC"
            });
            data.Add(new Customer()
            {
                Id = 4,
                Name = "Hermann",
                FamilyName = "Witz",
                EMail = "witz@gmail.com",
                Password = "testD",
                CustomerNumber = "testDataD"
            });

            return data;
        }
    }
}
