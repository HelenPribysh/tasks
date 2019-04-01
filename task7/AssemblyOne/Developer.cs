using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Developer: Employee
    {
        string a = Employee.CompanyNamePublic;
        string b = Employee.CompanyNameInternal;
        string c = Employee.CompanyNamePprotectedInternal;
        string d = Employee.CompanyNameProtected;
        //other fields can't be got access
    }

    class Developer2 : Employee2
    {
        string a = Employee2.CompanyNamePublic;
        string b = Employee2.CompanyNameInternal;
        string c = Employee2.CompanyNamePprotectedInternal;
        string d = Employee2.CompanyNameProtected;
        //other fields can't be got access
    }
}
