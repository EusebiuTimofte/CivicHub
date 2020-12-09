﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CivicHub.Dtos
{
    public class IssueDto
    {
        public Guid Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        //public ICollection<IssueState> IssueStates { get; set; }
    }
}