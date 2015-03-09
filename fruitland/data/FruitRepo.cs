using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fruitland.data
{
    public class FruitRepo :IFruitRepo
    {
        FruitContext _ctx;

        public FruitRepo(FruitContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Fruit> getFruits()
        {
            return _ctx.fruits;  
        }

        public IQueryable<Comment> getCommentsByFruit(int fruitId)
        {
            return _ctx.comments.Where(r => r.FruidId == fruitId);
        }


        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                //TODO: Log this error
                return false;
            }
        }

        public bool AddFruit(Fruit newFruit)
        {
            try
            {
                _ctx.fruits.Add(newFruit);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool AddComment(Comment newComment)
        {
            try
            {
                _ctx.comments.Add(newComment);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public IQueryable<Fruit> getFruitsIncludingReplies()
        {
            return _ctx.fruits.Include("Comments");
        }
    }
}