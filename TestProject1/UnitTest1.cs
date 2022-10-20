
using DocumentFormat.OpenXml.ExtendedProperties;
using Google.Apis.Util;
using Helpdesk.Data;
using Helpdesk.Models;
using Helpdesk.Repositories;
using Helpdesk.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NPoco;
using System.Configuration;
using Xunit;

namespace TestProject1
{
    public class Tests
    {
       

        private readonly CompanyService _companyService;
        private readonly Mock<CreateRepozitory> _createRepozitory = new Mock<CreateRepozitory>();
        private readonly Mock<ApplicationDbContext> _db = new Mock<ApplicationDbContext>();
      
        public Tests()
        {
            _companyService = new CompanyService(
               _db.Object,
               _createRepozitory.Object
              
            ) ;
        }

        [Fact]
        public async Task CreateTest()
        {
            var config = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json").Build();


            var builder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(config.GetConnectionString("DefaultConnection")).Options;
                

            using (var db = new ApplicationDbContext(builder))
                {

                //Arrange
          
                Companys model = new Companys
                {
                    NameCompany = "Fake Name",
                    NIP = "Fake Description",
                };

                _createRepozitory.Setup(x => x.Create(new Companys { NameCompany = model.NameCompany, NIP = model.NIP })).Returns(1); ;

                //Act
                var result =  _companyService.Create(model);

                //Assert
                Assert.IsTrue(result);


            }
           





        }
    }
}