using Moq;
using NUnit.Framework;
using CarCollection.WebApi.Lib;

namespace CarCollection.WebApi.Test.Controllers
{
    public abstract class ApiControllerBaseTests
    {
        protected Mock<IQueryFactory> QueryFactoryMock;
        protected Mock<ICommandFactory> CommandFactoryMock;

        [SetUp]
        public void SetUp()
        {
            QueryFactoryMock = new Mock<IQueryFactory>();
            CommandFactoryMock = new Mock<ICommandFactory>();

            SetUpConfig();
        }

        public abstract void SetUpConfig();
    }
}