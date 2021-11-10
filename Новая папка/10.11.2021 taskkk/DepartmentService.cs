using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._11._2021_taskkk
{
    public class DepartmentService : IDepartmentService
    {
        Department[] departments = new Department[0];
        public Department Create(Department department)
        {
            Array.Resize(ref departments, departments.Length + 1);
            departments[departments.Length - 1] = department;
            return department;
        }

        public bool Delete(int id)
        {
            departments = Array.FindAll(departments, d => d.Id != id);
            return true;
        }

        public Department Find(int id)
        {
            Department newdepartment = Array.Find(departments, d => d.Id == id);
            return newdepartment;
        }

        public int FindId()
        {
            if (departments.Length==0)
            {
                return 1;
            }
            return departments[departments.Length - 1].Id + 1;
        }

        public Department[] Read()
        {
            return this.departments;
        }

        public Department Update(int id, Department department)
        {
            Department department1 = Array.Find(departments, d => d.Id == id);
            department1 = department;
            return department;
        }
    }
}
