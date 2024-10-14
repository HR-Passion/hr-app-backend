﻿namespace DataAccesLayer.Entities.Base.Employees
{
    public class EmployeeInfo : BaseEntity
    {
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployeement { get; set; }
    }
}
