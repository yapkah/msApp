﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSAPP.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployees();
         Employee Add(Employee employee);
        Employee Update(int Id,Employee employeeChanges);
        Employee Delete(int Id);


    }

}
