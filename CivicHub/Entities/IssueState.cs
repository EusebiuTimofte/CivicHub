﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CivicHub.Entities
{
    public class IssueState: BaseEntity
    {
        
        public Guid IssueId { get; set; }
        public Issue Issue { get; set; }
        public Guid StateId { get; set; }
        public State State { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string CustomMessage { get; set; }
        public ICollection<IssueStateComment> IssueStateComments { get; set; }
        public ICollection<IssueStatePhoto> IssueStatePhotos { get; set; }
        public ICollection<IssueStateVideo> IssueStateVideos { get; set; }
        public ICollection<IssueStateReaction> IssueStateReactions { get; set; }
    }
}
