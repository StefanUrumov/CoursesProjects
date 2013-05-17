using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    class Student
    {
        //fields
        private string firstName;       
        private string middleName;
        private string lastName;       
        private long ssn;       
        private string permanentAddress;        
        private string mobilePhoneEmail;        
        private int course;        
        private Specialties specialty;       
        private Universities university;        
        private Faculties faculty;       

        //properties

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public long SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }

        public string MobilePhoneEmail
        {
            get { return this.mobilePhoneEmail; }
            set { this.mobilePhoneEmail = value; }
        }

        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Specialties Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public Universities University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        //constuctors
        public Student(string firstName, string middleName, string lastName, long ssn, string permanentAddress,  string mobilePhoneEmail, int course, Specialties specialty, Universities university, Faculties faculty)
        {              
            this.firstName = firstName;      
            this.middleName = middleName;
            this.lastName = lastName;       
            this.ssn = ssn;       
            this.permanentAddress = permanentAddress;
            this.mobilePhoneEmail = mobilePhoneEmail;
            this.course =  course;        
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;                          
        }                     
                       
        //methods 
        public override bool Equals(object obj)
        {
            if (this.ssn != (obj as Student).ssn)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2} \nSSN: {3} \nAddress: {4} \nMobile phone: {5} \nSpecialty: {6} \n" +
                "University: {7}", firstName, middleName, lastName, ssn, permanentAddress, mobilePhoneEmail, specialty, university);
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ lastName.GetHashCode() ^ ssn.GetHashCode();
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return (s1.ssn == s2.ssn);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return (s1.ssn != s2.ssn);
        }

        public object Clone()
        {
            return new Student(this.firstName, this.middleName, this.lastName, this.ssn, this.permanentAddress,
            this.mobilePhoneEmail, this.course, this.specialty, this.university, this.faculty) as object;
        }

        public int CompareTo(Student s)
        {
            if (firstName.CompareTo(s.firstName) != 0) //if they are not equal
            {
                return firstName.CompareTo(s.firstName);
            }
            else if (middleName.CompareTo(s.middleName) != 0)
            {
                return middleName.CompareTo(s.middleName);
            }
            else if (lastName.CompareTo(s.lastName) != 0)
            {
                return lastName.CompareTo(s.lastName);
            }
            else
            {
                return ssn.CompareTo(s.ssn);
            }
        }
   
    }                   
}                      
                          