using System;
using System.Reflection;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SoftwareAttribute : System.Attribute
    {
        public string ProjectName
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string Description
        {
            get { return Description; }
            set { Description = value; }
        }
        public string ClientName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string StartedDate
        {
            get { return StartedDate; }
            set { StartedDate = value; }
        }
        public string EndDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }

        public SoftwareAttribute(string message)
        {
            Console.WriteLine(message);
        }

        public SoftwareAttribute(string pName, string des, string cName, string sDate, string eDate)
        {
            ProjectName = pName;
            Description = des;
            ClientName = cName;
            StartedDate = sDate;
            EndDate = eDate;
        }
    }

    [SoftwareAttribute("Return details of the project.")]
    class HDFCAccount
    {
        //
    }

    [SoftwareAttribute("Return details of the project.")]
    class ICICIAccount
    {
        //
    }

    class Test
    {
        SoftwareAttribute attribute = (SoftwareAttribute)Attribute.GetCustomAttribute(typeof(HDFCAccount), typeof(SoftwareAttribute));
        public Test()
        {
            Console.WriteLine(attribute.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
        }
    }
}

