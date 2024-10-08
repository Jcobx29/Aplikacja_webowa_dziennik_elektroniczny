﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Domain.Model.TeacherInfo
{
    public class TeacherAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string ZipCode { get; set; }
        public int TeacherRef { get; set; }
        public Teacher Teacher { get; set; }
    }
}
