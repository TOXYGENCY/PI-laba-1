using PI_laba_1;
using System.Reflection.Metadata.Ecma335;

var Manager = new Manager
{
    Name = "Менеджер Всех Менеджеров",
    Workplace = "102",
    Bonus = 32500
};

var SysAdmin = new EmployeeWithPhone
{
    Name = "Эй УМеняСломалось Админович",
    PhoneNumber = "+8(800)5553535",
    Workplace = "1337"
};

var CEO = new CEO
{
    Name = "Начальник ПоНеважным Делам",
    Workplace = "A001",
    CompanyCar = "Лада Cullinan(Калина) PRO MAX Competition"
};

var SecurityGuard = new SecurityGuard
{
    Name = "Майк Шмидт Константинович",
    Workplace = "CAM-01",
    FinancialResponsibility = 120.50f,
    PhoneNumber = "+1(234)555-67-89"
};

var Accountant = new Accountant
{
    Name = "Денюжко Пересчет Рублёвич",
    Workplace = "Печатный станок (денежный)",
    Bonus = 99999999,
    DutyDescription = "Изначально производил учет финансов фирмы, однако в следствие решений, принятых на совещании прошлого года, назначен печатать купюры рублёвой валюты за соответсвтующий станок из-за недалёких соображений нашего Директора с отсутсвием какого-либо понимания принципа работы как инфляции, так и функционирования экономики в целом."
};

/* попытка в вывод всего в консось
foreach (var prop in typeof(employee).GetProperties())
{
    Console.WriteLine(prop.Name, prop.GetValue(obj1));
}*/

Console.WriteLine("все еще ворк ин прогресс");