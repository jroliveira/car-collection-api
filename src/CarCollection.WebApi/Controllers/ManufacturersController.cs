using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarCollection.WebApi.Lib;
using CarCollection.WebApi.Lib.Commands.ManufacturerCommands;
using CarCollection.WebApi.Lib.Queries.ManufacturerQueries;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Controllers
{
    public class ManufacturersController : ApiControllerBase
    {
        public ManufacturersController(
            IQueryFactory queryFactory,
            ICommandFactory commandFactory)
            : base(queryFactory, commandFactory)
        {

        }

        [HttpGet]
        public IEnumerable<Manufacturer> All()
        {
            var query = QueryFactory.CreateQuery<GetAllQuery>();
            var model = query.GetResult();

            return model;
        }

        [HttpGet]
        public Manufacturer GetBy(int id)
        {
            var query = QueryFactory.CreateQuery<GetByIdQuery>();
            query.Id = id;
            var model = query.GetResult();

            return model;
        }

        [HttpPost]
        public HttpResponseMessage Create(Manufacturer model)
        {
            var command = CommandFactory.CreateCommand<CreateCommand>();

            try
            {
                command.Execute(model);

                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception exception)
            {
                return ResponseError(exception.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage Update(Manufacturer model)
        {
            var command = CommandFactory.CreateCommand<UpdateCommand>();

            try
            {
                command.Execute(model);

                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception exception)
            {
                return ResponseError(exception.Message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var command = CommandFactory.CreateCommand<DeleteCommand>();

            try
            {
                command.Execute(id);

                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception exception)
            {
                return ResponseError(exception.Message);
            }
        }
    }
}
