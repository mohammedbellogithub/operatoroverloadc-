using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAss
{
    class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public int Level { get; set; }

        public static User operator +(User first, User second)
        {
            return new User() { Age = first.Age + second.Age };
        }
        public static bool operator >(User first, User second)
        {
            return first.Age > second.Age;
        }
        public static bool operator <(User first, User second)
        {
            return first.Age < second.Age;
        }
        public static User operator --(User age)
        {
            return new User() { Age = --age.Age };
        }
        public static User operator ++(User age)
        {
            return new User() { Age = ++age.Age };
        }
        public static bool operator true(User user) => user.Age == user.Level;
        public static bool operator false(User user) => user.Age != user.Level;
          
        public override string ToString()
        {
            return $"FullName: {FullName} Age: {this.Age} Level:{this.Level}";
        }
    }
}
