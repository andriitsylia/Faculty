﻿using WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Interfaces
{
    public interface IStudents
    {
        public IEnumerable<Student> Students { get; }
    }
}
