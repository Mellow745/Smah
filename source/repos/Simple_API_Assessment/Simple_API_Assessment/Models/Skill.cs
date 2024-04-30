using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_API_Assessment.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string? Name { get; set; }

        [ForeignKey("ApplicantId")] 
        public int ApplicantId { get; set; }

        public Applicant? Applicant { get; set; } 

    }
}
