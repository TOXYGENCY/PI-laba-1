using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_laba_1
{
    public class EmployeeWithPhone : Employee // Класс работников с номером телефона
    {
        public string PhoneNumber { get; set; } // Телефон - строка, тк длинный и может записываться по-разному +с ним никакой математики не должно происходить
    }
}
