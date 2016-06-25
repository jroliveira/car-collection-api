using CarCollection.WebApi.Lib.IoC;
using CarCollection.WebApi.Lib.Queries;

namespace CarCollection.WebApi.Lib
{
    public class QueryFactory : IQueryFactory
    {
        public TQuery CreateQuery<TQuery>()
            where TQuery : IQuery
        {
            return Container.Get<TQuery>();
        }
    }
}