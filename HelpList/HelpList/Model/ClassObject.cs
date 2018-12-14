using System.Collections.ObjectModel;

namespace HelpList.Model
{
    class ClassObject
    {
        //Instance fields
        private string _className;
        private string _classRoom;

        //Properties
        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
        public string ClassRoom
        {
            get { return _classRoom; }
            set { _classRoom = value; }
        }

        ObservableCollection<Student> ClassListStudent;
        ObservableCollection<Student> ClassListTeacher;
        //Constructor
        public ClassObject(string className, string classRoom)
        {
            _className = className;
            _classRoom = classRoom;

            // koden skal bruges til at tilknytte klassen elever og lærer
            ClassListStudent = new ObservableCollection<Student>();
            ClassListTeacher = new ObservableCollection<Student>();

        }
        public ClassObject()
        {
            // koden skal bruges til at tilknytte klassen elever og lærer
            ClassListStudent = new ObservableCollection<Student>();
            ClassListTeacher = new ObservableCollection<Student>();
        }

        //Methods
        public void AddStudentToClassList()
        {
            // virker ikke inu
            // ClassListStudent.Add(SelectedStudent);
        }
        public void AddTeacherToClassList()
        {
            // virker ikke inu
            // ClassListTeacher.Add(SelectedTeacher);
        }

        public override string ToString()
        {
            return $"{nameof(ClassName)}: {ClassName}, {nameof(ClassRoom)}: {ClassRoom}";
        }

    }
}
