using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Form_Validation_using_Javascript.Models
{
    public class StudentViewModel
    {
        [Display(Name = "Enter Name")]
        public string Name { get; set; }
        [Display(Name = "Enter School Name")]
        public string SchoolName { get; set; }
        [Display(Name = "Enter College Name")]
        public string CollegeName { get; set; }
        [Display(Name = "Enter Blood Group")]
        public string BloodGroup { get; set; }
        [Display(Name = "Enter Medical Issue")]
        public string MedicalIssues { get; set; }
    }
}
