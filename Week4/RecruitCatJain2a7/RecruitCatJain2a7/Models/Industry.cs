﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class Industry
    {
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        [DisplayName("Industry Name")]
        [Required(ErrorMessage = "Industry Name is required")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Enter Valid Industry Name")]
        public string IndustryName { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Enter Valid Industry Category")]
        [DisplayName("Industry Category")]
        public string IndustryCategory { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
