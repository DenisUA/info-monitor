﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDashboard.DAL.Models
{
    [TableName("Facts")]
    class Fact
    {
        public int Id { get; set; }
        public string FactText { get; set; }
    }
}
