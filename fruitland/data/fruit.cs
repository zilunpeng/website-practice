using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fruitland.data
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name{ get; set;}
        public string Description { get; set;}
        public byte[] PhotoFile { get; set;}

        public ICollection<Comment> Comments { get; set; }
    }
}