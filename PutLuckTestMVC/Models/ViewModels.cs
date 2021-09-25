using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PutLuckTestMVC.Models
{
    public class TeamMemberDish
    {
        public TeamMember user { get; set; }
        public List<Dish> newDish { get; set; }
    }
}
