using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class Contacts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Messages { get; set; }
    }
}
