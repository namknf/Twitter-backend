﻿namespace Twitter_backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public int Password { get; set; }
    }
}
