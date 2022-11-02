﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week06.Abstractions;

namespace Week06.Entities
{
    public class BallFactory : IToyFactory
    {
        public Toy CreateNew() 
        {
            return new Toy();
        }
    }
}
