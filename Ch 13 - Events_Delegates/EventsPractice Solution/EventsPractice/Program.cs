using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oneStu = new Student();
            EventListener listener = new EventListener(oneStu);
            oneStu.Changed += new ChangedEventHandler(StudentChanged2);
            oneStu.IdNum = 2345;
            oneStu.IdNum = 4567;
            oneStu.Gpa = 3.2;
            Console.ReadKey();
        }

        public static void StudentChanged2(object sender, EventArgs e)
        {
            Console.WriteLine("StudentChanged 2 invoked ");
        }

    }




    public delegate void ChangedEventHandler(object sender, EventArgs e);

    class Student
    {
        private int idNum;
        private double gpa;
        public event ChangedEventHandler Changed; //you cannot assign values to the event as easily as you can to ordinary data fields. You can take only two actions on an event: You can compose a new delegate onto it using the += operator, and you can remove a delegate from it using the −= operator.

        public int IdNum
        {
            get { return idNum;}
            set
            {
                idNum = value;
                OnChanged(EventArgs.Empty); //the EventArgs.Empty field simply tells the client that an event has occurred, without specifying details.
            } 
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                gpa = value;
                OnChanged(EventArgs.Empty);
            }
        }

        private void OnChanged(EventArgs e)
        {
            Changed(this, e); //invoking the event
        }

    }

    class EventListener
    {
        private Student stu;
        public EventListener(Student student)
        {
            stu = student;
            stu.Changed += new ChangedEventHandler(StudentChanged); //whichever student object was passed in at instantiation now has StudentChanged added to the Changed Event
        }

        private void StudentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The student has changed. ");
            Console.WriteLine("ID# {0} GPA {1}", stu.IdNum, stu.Gpa);
        }
    }
}


