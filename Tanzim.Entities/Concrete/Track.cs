﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace Tanzim.Entities.Concrete
{
    public class Track:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public int CategoryId { get; set; }
    }
}
