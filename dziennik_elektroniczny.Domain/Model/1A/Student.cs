﻿using dziennik_elektroniczny.Domain.Model._1A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo ContactStudentInfo { get; set; }
        public Biology Biology { get; set; }
        public Chemistry Chemistry { get; set; }
        public English English { get; set; }
        public Geography Geography { get; set; }
        public German German { get; set; }
        public History History { get; set; }
        public Math Math { get; set; }
    }
}