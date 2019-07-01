using C_SWInternPerformance.Data;
using C_SWInternPerformance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    class PEmployee:BasePresenter
    {
        private IEmployee vEmployee;
        public PEmployee(IEmployee view) => this.vEmployee = view;
        public PEmployee() { }
        // Get ONE single employee based on input ID.
        public DetailedEmployeeData GetEmployee(int ID)
        {
            Employee emp = new Employee();
            return emp.GetEmployee(ID);
        }
        // Get lists.
        // Get a list of employees.
        public BindingList<EmployeeData> GetEmployees()
        {
            Employee emp = new Employee();
            return emp.GetEmployeeDatas();
        }
        // Get a list of Position for the combobox.
        public BindingList<PositionData> GetPositions()
        {
            Employee emp = new Employee();
            return emp.PositionList();
        }
        // Get a list of Levels for the combobox.
        public BindingList<LevelData> GetLevels()
        {
            Employee emp = new Employee();
            return emp.LevelList();
        }
        // Get a list of Branches for the combobox.
        public BindingList<BranchData> GetBranches()
        {
            Employee emp = new Employee();
            return emp.BranchList();
        }

        // Buttons functions, INSERTING into, UPDATING database.
        public int Save(int ID)
        {
            Employee employee = new Employee
            {
                EmployeeID = vEmployee.EmployeeID,
                EmployeeName = vEmployee.EmployeeName,
                PositionID = vEmployee.PositionID,
                BranchID = vEmployee.BranchID,
                StartDate = vEmployee.StartDate,
                EndDate = vEmployee.EndDate,
                Email = vEmployee.Email,
                Mobile = vEmployee.Mobile,
                Address = vEmployee.Address,
                Birthday = vEmployee.Birthday,
                LevelID = vEmployee.LevelID,
                Desire = vEmployee.Desire,
                Del = vEmployee.Del,
                Remark = vEmployee.Remark
            };
            if (ID == -1)
            {
                employee.AddEmployee();
                return 0;
            }

            else
            {
                employee.SaveEmployee();
                return 1;
            }
        }
    }
}
