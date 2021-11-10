using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._11._2021_taskkk
{
    interface IDepartmentService
    {
        Department Create(Department department);
        Department[] Read();
        Department Update(int id, Department department);
        bool Delete(int id);
        Department Find(int id);
        int FindId();

    }
}
