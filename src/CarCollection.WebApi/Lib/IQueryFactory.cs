using CarCollection.WebApi.Lib.Queries;

namespace CarCollection.WebApi.Lib
{
    public interface IQueryFactory
    {
        TQuery CreateQuery<TQuery>()
            where TQuery : IQuery;
    }
}