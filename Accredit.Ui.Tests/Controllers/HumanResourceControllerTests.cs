using System.Collections.Generic;
using System.Threading.Tasks;
using Accredit.Core.Areas.Paging;
using Accredit.Domain.Repositories;
using Accredit.Shared.Entities;
using Accredit.Ui.Controllers;
using Accredit.Ui.Models;
using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Accredit.Ui.Tests.Controllers
{
    public class HumanResourceControllerTests
    {
        private readonly Mock<IHumanResourceRepository> _humanResourceRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;


        private readonly HumanResourceController _sut;
        public HumanResourceControllerTests()
        {
            _humanResourceRepositoryMock = new Mock<IHumanResourceRepository>();
            _mapperMock = new Mock<IMapper>();

            _sut = new HumanResourceController(_humanResourceRepositoryMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task Given_Index_When_Invoked_Then_ShouldReturnIndexView()
        {
            //Arrange
            const int pageNumber = 1;

            var humanResourcesMockResponse = new PaginatedList<HumanResource>{TotalPages = 1, PageIndex = 2};
            _humanResourceRepositoryMock.Setup(x => x.GetHumanResources(pageNumber)).ReturnsAsync(humanResourcesMockResponse);

            var viewModelMappedResponse = new PaginatedList<HumanResourceViewModel>();
            _mapperMock.Setup(x => x.Map<PaginatedList<HumanResourceViewModel>>(humanResourcesMockResponse))
                .Returns(viewModelMappedResponse);

            //Act
            var result = await _sut.Index(pageNumber) as ViewResult;

            //Assert
            result.Should().NotBeNull();
            result?.ViewName.Should().Be("Index");
        }

        [Fact]
        public async Task Given_Index_When_Invoked_Then_ShouldReturnAPaginatedListOfHumanResources()
        {
            //Arrange
            const int pageNumber = 1;

            var humanResourcesMockResponse = new PaginatedList<HumanResource>();
            _humanResourceRepositoryMock.Setup(x => x.GetHumanResources(pageNumber)).ReturnsAsync(humanResourcesMockResponse);

            var viewModelMappedResponse = new PaginatedList<HumanResourceViewModel>{new HumanResourceViewModel
            {
                FirstName = "Unit",
                LastName = "Test"
            }};
            _mapperMock.Setup(x => x.Map<PaginatedList<HumanResourceViewModel>>(humanResourcesMockResponse))
                .Returns(viewModelMappedResponse);

            //Act
            var result = await _sut.Index(pageNumber) as ViewResult;

            //Assert
            result.Should().NotBeNull();
            result?.Model.Should().BeOfType<PaginatedList<HumanResourceViewModel>>();

            var viewModelResult = result?.Model as PaginatedList<HumanResourceViewModel>;
            viewModelResult.Should().NotBeNull();
            
            const int expectedHumanResourcesCount = 1;
            viewModelResult?.Count.Should().Be(expectedHumanResourcesCount);
        }
    }
}
