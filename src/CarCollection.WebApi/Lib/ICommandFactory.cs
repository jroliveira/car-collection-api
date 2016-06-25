namespace CarCollection.WebApi.Lib
{
    public interface ICommandFactory
    {
        TCommand CreateCommand<TCommand>();
    }
}