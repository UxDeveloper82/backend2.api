﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public string Post { get; set; }

        public DateTime Created { get; set; }

        public string Author { get; set; }
    }
}
