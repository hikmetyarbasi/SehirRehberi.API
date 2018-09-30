﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Dto
{
    public class CityDetailForDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
