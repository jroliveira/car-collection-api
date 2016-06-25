namespace CarCollection.WebApi.Lib.Queries
{
    public interface IQuery
    {

    }

    public interface IQuery<out TResult> : IQuery
    {
        TResult GetResult();
    }
}