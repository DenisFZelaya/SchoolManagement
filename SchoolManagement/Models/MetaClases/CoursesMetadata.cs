using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class CoursesMetadata
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1,8)]
        public int Credits { get; set; }
    }

    [MetadataType(typeof(CoursesMetadata))]
    public partial class Course
    {

    }
}