using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Employee.CompanyNamePublic;
            string b = Employee.CompanyNameInternal;
            string d = Employee.CompanyNamePprotectedInternal;

            string a1 = Employee2.CompanyNamePublic;
            string b1 = Employee2.CompanyNameInternal;
            string d1 = Employee2.CompanyNamePprotectedInternal;

            //other fields can't be got access
        }
    }
}
