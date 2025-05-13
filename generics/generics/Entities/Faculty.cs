using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using generics.Interfaces;

namespace generics.Entities
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private IRepository<Group, int> _groups = new InMemoryRepository<Group, int>();

        public void AddGroup(Group g)
        {
            _groups.Add(g.Id, g);
        }
        public void RemoveGroup(int id)
        {
            _groups.Remove(id);
        }
        public IEnumerable<Group> GetAllGroups()
        {
            return _groups.GetAll();
        }
        public Group GetGroup(int id)
        {
            return _groups.Get(id);
        }
        public void AddStudentToGroup(int groupId, Student s)
        {
            var group = _groups.Get(groupId);
            if (group != null)
            {
                group.AddStudent(s);
            }
        }
        public void RemoveStudentFromGroup(int groupId, int studentId)
        {
            var group = _groups.Get(groupId);
            if (group != null)
            {
                group.RemoveStudent(studentId);
            }
        }

        public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
        {
            var group = _groups.Get(groupId);
            if (group != null)
            {
                return group.GetAllStudents();
            }

            return Enumerable.Empty<Student>();
        }

        public Student FindStudentInGroup(int groupId, int studentId)
        {
            var group = _groups.Get(groupId);
            if (group != null)
            {
                return group.FindStudent(studentId);
            }

            return null;
        }


    }
}
