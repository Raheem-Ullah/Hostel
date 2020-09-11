using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hostel.Models
{
    public class Student
    {
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name = "Candidate Name")]
        public String Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter father name"), MaxLength(30)]
        [Display(Name = "Father Name")]
        public String FatherName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Date of Birth")]
        public String DOB { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter guardian name"), MaxLength(30)]
        [Display(Name = "Guardian Name")]
        public String GuardianName { get; set; }

        [Required(ErrorMessage = "Please enter guardian name"), MaxLength(100)]
        public String InstituteName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Nationality"), MaxLength(30)]
        public String Nationality { get; set; }

        [Required]
        [RegularExpression("^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$", ErrorMessage = "Invalid C.N.I.C format")]
        public String CNIC { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public String Address { get; set; }

        [Required(ErrorMessage = "Please enter Mobile No")]
        [DataType(DataType.PhoneNumber)]
        public String CellNum { get; set; }

        [Required(ErrorMessage = "Please enter Emergency No")]
        [DataType(DataType.PhoneNumber)]
        public String EmergencyNum { get; set; }
    }


}