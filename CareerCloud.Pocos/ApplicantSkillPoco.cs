﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
    class ApplicantSkillPoco :IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Applicant { get; set; }

        public string Skill { get; set; }

        [Column("Skill_Level")]
        public string SkillLevel { get; set; }

        [Column("Start_Month")]
        public Byte StartMonth { get; set; }

        [Column("Start_Year")]
        public int StartYear { get; set; }

        [Column("End_Month")]
        public Byte EndMonth { get; set; }

        [Column("End_Year")]
        public int EndYear { get; set; }

        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }


    }
}
