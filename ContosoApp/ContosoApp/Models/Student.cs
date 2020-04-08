﻿using System;
using System.Collections.Generic;

namespace ContosoApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public decimal AverageMark { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}