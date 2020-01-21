using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inotify
{
   public class Student : INotifyPropertyChanged
    {
        public string name;
       public string group;
        public string birthdayday;
        public string gender;
        public string weight;
       public string height;



        public string Name {
            get { return name; }
            set
               {
                name = value;
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string Group {
            get { return group; }
            set
                        {
                group = value;
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Group)));
            }
        }

        public string BirthdayDay 
        { get { return birthdayday; } 
            set { birthdayday = value;
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BirthdayDay)));
            } }


        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Gender)));
            }
        }

        public string Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Weight)));
            }
        }

        public string Height
        {
            get { return height; }
            set
            {
                height = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Height)));
            }
        }


       public event PropertyChangedEventHandler PropertyChanged;



    }
}
