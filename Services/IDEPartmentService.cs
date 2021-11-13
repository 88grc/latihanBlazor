using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTS.Models;

namespace UTS.Services
{
    public interface IDEPartmentService
    {
        Task<IEnumerable<Department>> GetAll(); //mengambil semua data department
        Task<Department> GetById(int id); //mengambil 1 data aja
    }
}