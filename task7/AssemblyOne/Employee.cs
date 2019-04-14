using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    internal class Employee
    {
        public const string CompanyNamePublic = "_CompanyNamePublic";
        private const string CompanyNamePrivate = "_CompanyNamePrivate";
        protected const string CompanyNameProtected = "_CompanyNameProtected";
        internal const string CompanyNameInternal = "_CompanyNameInternal";
        protected internal const string CompanyNamePprotectedInternal = "_CompanyNamePprotectedInternal";
        private protected string CompanyNamePrivateProtected = "_CompanyNamePrivateProtected";
    }

    public class Employee2
    {
        public const string CompanyNamePublic = "_CompanyNamePublic";
        private const string CompanyNamePrivate = "_CompanyNamePrivate";
        protected const string CompanyNameProtected = "_CompanyNameProtected";
        internal const string CompanyNameInternal = "_CompanyNameInternal";
        protected internal const string CompanyNamePprotectedInternal = "_CompanyNamePprotectedInternal";
        private protected string CompanyNamePrivateProtected = "_CompanyNamePrivateProtected";
    }
}
