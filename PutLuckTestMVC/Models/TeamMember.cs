using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PutLuckTestMVC.Models
{
    [Table("teammember")]
    public class TeamMember
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AttendanceDate { get; set; }

        public string GuestName { get; set; }
    }
}
