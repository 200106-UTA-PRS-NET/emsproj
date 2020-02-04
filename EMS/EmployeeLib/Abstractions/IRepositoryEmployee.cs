﻿using System.Collections.Generic;

namespace EmployeeLib.Abstractions
{
    public interface IRepositoryEmployee<T>
    {
        IEnumerable<T> GetEmployees();
        T GetEmployeeById(int id);
        void AddEmployee(T employee);
        void ModifyEmployee(T employee);
        void RemoveEmployee(int id);
    }
}
