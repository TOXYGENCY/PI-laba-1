using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PI_laba_1
{
    public class Employee
    {
        //ФИО:
        public string Name { get; set; }

        //Номер офиса или пост:
        public string Workplace { get; set; } //строка, чтобы была возможность записывать в разной форме: 001, 92-КА и тд
    }
}
