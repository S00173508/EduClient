﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduClient.Models
{
    public class PostModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public int BoardID { get; set; }
    }
}