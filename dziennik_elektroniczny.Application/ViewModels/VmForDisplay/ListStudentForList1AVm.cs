﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik_elektroniczny.Application.ViewModels.VmForDisplay
{
    public class ListStudentForList1AVm
    {
        public List<StudentForList1AVm> Students1A { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }
}
