using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDiem.Areas.Admin.Models
{
    public class DashboardModel
    {
        public int numberOfAccounts { get; set; }
        public int numberOfStudents { get; set; }
        public int numberOfTeachers { get; set; }
        public int numberOfSemesters { get; set; }
        public int numberOfCategories { get; set; }
        public int numberOfSubjects { get; set; }
        public int numberOfPosts { get; set; }
        public int numberOfClasses { get; set; }
    }
}