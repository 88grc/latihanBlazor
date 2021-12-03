using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTS.Models;

namespace UTS.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();//ngambil data semua employee
        Task<Employee> GetById(int id); //ambil data salah satu employee
        Task<Employee> Update(int id, Employee employee);
        Task<Employee> Add(Employee Employee);
    }
}