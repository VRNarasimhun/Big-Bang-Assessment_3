﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaniniTourismApplication.Model
{
    public class Agent
    {
        public Agent()
        {
            Name = string.Empty;
            Gender = "Unknown";
        }
        [Key]
        public int AgentId { get; set; }
        [ForeignKey("AgentId")]
        public User? Users { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public int? AgencyID { get; set; }
        public string? AgencyName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? IsApproved { get; set; }
        public string? GSTnumber { get; set; }

    }
}

