using fruitland.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fruitland.Controllers
{
    public class FruitController : ApiController
    {
        private IFruitRepo _repo;

        public FruitController(IFruitRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<Fruit> Get(bool includeReplies = false)
        {
            if (includeReplies == true)
            {
                return _repo.getFruitsIncludingReplies()
                       .OrderByDescending(t => t.Id)
                       .Take(25)
                       .ToList();
            }
            else {
                return _repo.getFruits()
                       .OrderByDescending(t => t.Id)
                       .Take(25)
                       .ToList();
            }

        }

        public IEnumerable<Comment> GetComment(int fruitId)
        {
            return _repo.getCommentsByFruit(fruitId);
        }

        public HttpResponseMessage Post([FromBody]Fruit newFruit)
        {
            
            if (_repo.AddFruit(newFruit) && _repo.Save())
            {
                return Request.CreateResponse(HttpStatusCode.Created, newFruit);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
