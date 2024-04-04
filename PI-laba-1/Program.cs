using PI_laba_1;

// Образцы использования всех классов, что я тут напрограммировал:

var Manager = new Manager
{
    Name = "Всем Менеджерам Менеджер",
    Workplace = "102",
    Bonus = 32500,
    ClientList = new string[] { "И.И. Сверхразум", "И.Я. Тоже", "А.Я. Кто" }
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
    Bonus = 99999999,
    Workplace = "A001",
    CompanyCar = "Лада Cullinan(Калина) PRO MAX Competition"
};

var SecurityGuard = new SecurityGuard
{
    Name = "Майк Шмидт Фреддифазбирович",
    Workplace = "CAM-01",
    FinancialResponsibility = 120.50f,
    PhoneNumber = "+1(234)555-67-89"
};

var Accountant = new Accountant
{
    Name = "Денюжко Пересчет Рублёвич",
    Workplace = "Печатный станок (денежный)",
    Bonus = 2147483647,
    DutyDescription = "Изначально производил учет финансов фирмы, однако в следствие решений, принятых на совещании прошлого года, назначен печатать купюры рублёвой валюты за соответсвтующий станок из-за недалёких соображений нашего Директора с отсутсвием какого-либо понимания принципа работы как инфляции, так и функционирования экономики в целом."
};

