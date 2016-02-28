using System;

namespace EmployeeManager.DataAccess
{
    public interface IHasId
    {
        string Id { get; set; }
    }
    public interface ISecured
    {
        bool Locked { get; set; }
        bool Hidden { get; set; }
    }
    public interface IAuditable : IHasId
    {
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime ModifiedAt { get; set; }
    }
    public class HasId : IHasId
    {
        public string Id { get; set; }
    }
    public class AuditFields : HasId, IAuditable, ISecured
    {
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool Locked { get; set; }
        public bool Hidden { get; set; }
    }
    public class LookUp : AuditFields
    {
        public string Name { get; set; }
        public string Notes { get; set; }
    }

    public class Employee : AuditFields
    {
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmployeeNo { get; set; }
        public string JobTitle { get; set; }
        public Gender Gender { get; set; }
    }

    public class Salary : AuditFields
    {
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class GenericProperties
    {
        public const string Id = "Id";
        public const string CreatedBy = "CreatedBy";
        public const string CreatedAt = "CreatedAt";
        public const string ModifiedAt = "ModifiedAt";
        public const string ModifiedBy = "ModifiedBy";
        public const string Locked = "Locked";
    }
}
