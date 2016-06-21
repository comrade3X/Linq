using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Operation
{
    public class Student
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
    }

    public class Information
    {
        public virtual IEnumerable<Student> Students { get; set; }
        public virtual int Id { get; set; }
    }
}
