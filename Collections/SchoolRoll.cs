using System;
using System.Collections.Generic;

namespace Collections
{
    public class SchoolRoll
    {
        private HashSet<Student> _students = new HashSet<Student>();

        public IEnumerable<Student> Students { get { return _students;  } }
        //Enumerbale doesn't allow modifications of the existing list

        public void AddStudents(IEnumerable<Student> students)
        {
            //allows to pass in any type of collection
            _students.UnionWith(students);
        }
    }
}
