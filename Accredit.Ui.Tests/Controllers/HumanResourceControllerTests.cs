using System.Collections.Generic;
using System.Threading.Tasks;
using Accredit.Domain.Repositories;
using Accredit.Shared.Entities;
using Accredit.Ui.Controllers;
using Accredit.Ui.Models;
using Accredit.Ui.Settings;
using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace Accredit.Ui.Tests.Controllers
{
    public class HumanResourceControllerTests
    {
        private Mock<IHumanResourceRepository> _humanResourceRepositoryMock;
        private Mock<IMapper> _mapperMock;
        private Mock<IOptions<UiSettings>> _uiSettingsMock;

        private HumanResourceController _sut;
        public HumanResourceControllerTests()
        {
            _humanResourceRepositoryMock = new Mock<IHumanResourceRepository>();
            _mapperMock = new Mock<IMapper>();
            _uiSettingsMock = new Mock<IOptions<UiSettings>>();

            _sut = new HumanResourceController(_humanResourceRepositoryMock.Object, _mapperMock.Object,
                _uiSettingsMock.Object);
        }

        [Fact]
        public async Task Given_Index_When_Invoked_Then_ShouldReturnIndexView()
        {
            //Act
            var result = await _sut.Index() as ViewResult;

            //Assert
            result.Should().NotBeNull();
            result?.ViewName.Should().Be("Index");
        }


        [Fact]
        public async Task Given_Index_When_Invoked_Then_ShouldReturnAListOfHumanResources()
        {
            //Arrange
            var humanResourcesMockResponse = new List<HumanResource>();
            _humanResourceRepositoryMock.Setup(x => x.GetHumanResources()).ReturnsAsync(humanResourcesMockResponse);

            var viewModelMappedResponse = new List<HumanResourceViewModel>{new HumanResourceViewModel
            {
                FirstName = "Unit",
                LastName = "Test"
            }};
            _mapperMock.Setup(x => x.Map<List<HumanResourceViewModel>>(humanResourcesMockResponse))
                .Returns(viewModelMappedResponse);

            //Act
            var result = await _sut.Index() as ViewResult;

            //Assert
            result.Should().NotBeNull();
            result?.Model.Should().BeOfType<List<HumanResourceViewModel>>();

            var viewModelResult = result?.Model as List<HumanResourceViewModel>;
            viewModelResult.Should().NotBeNull();
            viewModelResult?.Count.Should().Be(1);
        }
    }
}
