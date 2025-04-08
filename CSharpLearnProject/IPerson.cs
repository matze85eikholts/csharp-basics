using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; } // Фамилия
        void Introduce();              // Метод для представления
    }
}
