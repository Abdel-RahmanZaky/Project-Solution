﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Models
{
    // Model
    // Poco Class
    public class Department : ModelBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

        // Navigational Property => [Many]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
