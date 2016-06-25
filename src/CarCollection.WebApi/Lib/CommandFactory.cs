using CarCollection.WebApi.Lib.IoC;

namespace CarCollection.WebApi.Lib
{
    public class CommandFactory : ICommandFactory
    {
        public TCommand CreateCommand<TCommand>()
        {
            return Container.Get<TCommand>();
        }
    }
}