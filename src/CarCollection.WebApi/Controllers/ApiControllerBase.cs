using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarCollection.WebApi.Lib;

namespace CarCollection.WebApi.Controllers
{
    public class ApiControllerBase : ApiController
    {
        protected readonly IQueryFactory QueryFactory;
        protected readonly ICommandFactory CommandFactory;

        public ApiControllerBase(
            IQueryFactory queryFactory,
            ICommandFactory commandFactory)
        {
            QueryFactory = queryFactory;
            CommandFactory = commandFactory;
        }

        protected readonly Func<string, HttpResponseMessage> ResponseError = m => new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.ExpectationFailed,
            Content = new StringContent(m)
        };
    }
}