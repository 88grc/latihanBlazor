using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTS.Models;

namespace UTS.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();//ngambil data semua employee
        Task<Employee> GetEmployee(int id); //ambil data salah satu employee
    }
}