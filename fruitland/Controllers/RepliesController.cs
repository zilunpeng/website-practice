using fruitland.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fruitland.Controllers
{
    public class RepliesController : ApiController
    {
        private IFruitRepo _repo;
        public RepliesController(IFruitRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<Comment> Get(int fruitId)
        {
            return _repo.getCommentsByFruit(fruitId);
        }

        public HttpResponseMessage Post(int fruitId, [FromBody] Comment newComment) 
        {
            if (newComment.Created == default(DateTime))
            {
                newComment.Created = DateTime.UtcNow;
            }

            newComment.FruidId = fruitId;

            if (_repo.AddComment(newComment) && _repo.Save())
            {
                return Request.CreateResponse(HttpStatusCode.Created, newComment);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
