using Moq;
using NUnit.Framework;
using CarCollection.WebApi.Controllers;
using CarCollection.WebApi.Lib.Commands.VehicleCommands;
using CarCollection.WebApi.Lib.Queries.VehicleQueries;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Test.Controllers
{
    [TestFixture]
    public class VehiclesControllerTests : ApiControllerBaseTests
    {
        private Mock<GetByIdQuery> _getByIdQueryMock;
        private Mock<GetAllQuery> _getAllQueryMock;
        private VehiclesController _controller;
        private Mock<CreateCommand> _createCommandMock;
        private Mock<UpdateCommand> _updateCommandMock;
        private Mock<DeleteCommand> _deleteCommandMock;

        public override void SetUpConfig()
        {
            _getByIdQueryMock = new Mock<GetByIdQuery>();
            _getAllQueryMock = new Mock<GetAllQuery>();
            _createCommandMock = new Mock<CreateCommand>();
            _updateCommandMock = new Mock<UpdateCommand>();
            _deleteCommandMock = new Mock<DeleteCommand>();

            QueryFactoryMock.Setup(query => query.CreateQuery<GetByIdQuery>()).Returns(_getByIdQueryMock.Object);
            QueryFactoryMock.Setup(query => query.CreateQuery<GetAllQuery>()).Returns(_getAllQueryMock.Object);
            CommandFactoryMock.Setup(command => command.CreateCommand<CreateCommand>()).Returns(_createCommandMock.Object);
            CommandFactoryMock.Setup(command => command.CreateCommand<UpdateCommand>()).Returns(_updateCommandMock.Object);
            CommandFactoryMock.Setup(command => command.CreateCommand<DeleteCommand>()).Returns(_deleteCommandMock.Object);

            _controller = new VehiclesController(
                QueryFactoryMock.Object,
                CommandFactoryMock.Object);
        }

        [Test]
        public void All_DeveChamarGetAllQueryUmaVez()
        {
            _controller.All();

            _getAllQueryMock.Verify(query => query.GetResult(), Times.Once);
        }

        [Test]
        public void GetBy_DadoId_DeveChamarGetByIdQueryUmaVez()
        {
            _controller.GetBy(It.IsAny<int>());

            _getByIdQueryMock.Verify(query => query.GetResult(), Times.Once);
        }

        [Test]
        public void Create_DadoModel_DeveChamarCreateCommandUmaVez()
        {
            _controller.Create(It.IsAny<Vehicle>());

            _createCommandMock.Verify(query => query.Execute(It.IsAny<Vehicle>()), Times.Once);
        }

        [Test]
        public void Update_DadoModel_DeveChamarUpdateCommandUmaVez()
        {
            _controller.Update(It.IsAny<Vehicle>());

            _updateCommandMock.Verify(query => query.Execute(It.IsAny<Vehicle>()), Times.Once);
        }

        [Test]
        public void Delete_DadoId_DeveChamarDeleteCommandUmaVez()
        {
            _controller.Delete(It.IsAny<int>());

            _deleteCommandMock.Verify(query => query.Execute(It.IsAny<int>()), Times.Once);
        }
    }
}