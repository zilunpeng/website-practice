using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fruitland.data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

        //Reference to Fruit class
        public int FruidId { get; set; }
    }
}
