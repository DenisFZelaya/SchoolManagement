﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class StudentsMetadata
    {
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Firt Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Date of Enrollment")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }

    [MetadataType(typeof(StudentsMetadata))]
    public partial class Student { }

}