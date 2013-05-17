using System;
using System.Linq;

namespace SecondTask
{
    class Person
    {
        public enum Gender
        {
            Male,
            Female
        };


        private Gender personGender;
        private string personName;
        private int personAge;   
            
        public int PersonAge
        {
            get
            {
                return this.personAge;
            }
            set
            {
                if (this.personAge >= 0 && this.personAge <= 126)
                {                 
                    this.personAge = value;   
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The person can not be at this age!Too old or too young.");
                }
            }
        }

        public string PersonName
        {
            get
            {
                return this.personName;
            }
            set
            {
                if (personName != string.Empty)
                {                 
                    this.personName = value;   
                }
                else
                {
                    throw new NullReferenceException("The name of the person can not be null!");
                }
            }
        }

        public Gender PersonGender
        {
            get
            {
                return this.personGender;
            }
            set
            {
                this.personGender = value;
            }
        }

        public void CreatePerson(int personNumber)
        {
            //Person newPerson = new Person();
            //newPerson.PersonAge = yearsOld;
            PersonAge = personNumber;

            if (personNumber % 2 == 0)
            {
                PersonName = "Batkata";
                PersonGender = Gender.Male;                
            }
            else
            {
                PersonName = "Maceto";
                PersonGender = Gender.Female;
            }
        }

        public override string ToString()
        {
            return String.Format("This person is called {0}, {1} years old - {2}!", PersonName, PersonAge, PersonGender);
        }
    }
}
