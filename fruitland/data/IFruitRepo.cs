using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitland.data
{
    public interface IFruitRepo
    {
        IQueryable<Fruit> getFruits();
        IQueryable<Fruit> getFruitsIncludingReplies();
        IQueryable<Comment> getCommentsByFruit(int fruitId);

        bool Save();
        bool AddFruit(Fruit newFruit);
        bool AddComment(Comment newComment);
    }
}
