using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inotify2
{
   public class Student
    {
        public string name;
        public string group;
        public string birthdayday;
        public string gender;
        public string weight;
        public string height;



        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Group
        {
            get { return group; }
            set
            {
                group = value;

            }
        }

        public string BirthdayDay
        {
            get { return birthdayday; }
            set
            {
                birthdayday = value;

            }
        }


        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;

            }
        }

        public string Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }

        public string Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
    }
}
