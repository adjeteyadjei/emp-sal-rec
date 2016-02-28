namespace EmployeeManager.DataAccess
{
    public static class DbContext
    {
        public static BaseRepository<Employee> Employees = new BaseRepository<Employee>("Employees"); 
        public static BaseRepository<Salary> Salaries = new BaseRepository<Salary>("Salaries"); 
    }
}
