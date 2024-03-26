﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ContosoUniversity.Models
{
	public class Course
	{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 5)]
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        [ValidateNever]
        public Department Department { get; set; }
        [ValidateNever]
        public ICollection<Enrollment> Enrollments { get; set; }
        [ValidateNever]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}

