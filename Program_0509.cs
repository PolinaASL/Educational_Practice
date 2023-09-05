// See https://aka.ms/new-console-template for more information

//СТРУКТУРА ПРОГРАММ

using System.Globalization;

Console.WriteLine("Hello, World!");
Console.WriteLine("The first");
{
    Console.WriteLine("The second");
}


//ПЕРЕМЕННЫЕ И КОНСТАНТЫ

string name = "Drake";
Console.WriteLine(name);
name = "Jake";

Console.WriteLine(name);
const string Name = "Drake";
//Name = "Jake"; - выдаст ошибку


//ЛИТЕРАЛЫ

//логические литералы
Console.WriteLine(true);
Console.WriteLine(false);

//целочисленные литарелы
Console.WriteLine(-1);      //десятичная форма
Console.WriteLine(0b11);    //двоичная форма
Console.WriteLine(0x0A);    //шестнадцатеричная форма

//вещественные литералы
Console.WriteLine(3.2E-1);  //E = "*10^"

//символьные литералы
Console.WriteLine('3');
Console.WriteLine('G');

   //  \n - перевод строки
   //  \t - табуляция
   //  \\ - слэш
   //  \x - представляет использования шестнадцатеричных кодов ASCII

Console.WriteLine('\x98');
Console.WriteLine('\x65');

   //  \u - ещё один способ определения символьных литералов (табл. Unicode)

Console.WriteLine('\u0556');

//строковые литералы
Console.WriteLine("Corporation \"Juje\"");     //необходимы кавычки в тексте строки
Console.WriteLine("Good morning, \n" + name);  //переход на другую строку
                                               //null - ссылка без указаний, отсуствие значения

//ТИПЫ ДАННЫХ

    //bool хранит логические литералы
    //byte хранит целое число от 0 до 255 и занимаеи 1 байт
    //sbyte хранит целое число от -128 до 127 и занимает 1 байт
    //short хранит целое число от -32768 до 32767 и занимает 2 байта
    //ushort хранит целое число от 0 до 65535 и занимает 2 байта
    //int хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
    //uint хранит целое число от 0 до 4294967295 и занимает 4 байта
    //long хранит целое число от -922337288036854775 до 9223372036854775807 и занимает 8 байт
    //ulong хранит целое число от 0 до 18446744073709551615 и занимает 8 байт
    //float хранит число с плавающей точкой от -3.4*20^38 до 3.4*20^38 и занимает 4 байта
    //double хранит число с плавающей точкой от +-5.0*10^-324 до +-1.7*10^308 и занимает 8 байта
    //decimal хранит десятичное дробное число, без десятичной запятой имеет значение от +-1.0*10^-28
        // до +-7.2286*10^28, может хранить 28
    //char хранить одиновчный символ в кодировке Unicode и занимает 2 байта

    char a = 'A';

    //string хранит набор символов Unicode

    string hello = "Hello";

    //object хранит значение любого типа данных и занимает 4 юайта на 32-разядной платформе и 8 байтов на 64-разрядной платформе
    
    object fo = 36;
    object ro = 7.56;
    object go = "hello there";

string NAME = "Drake";
int age = 42;
bool isEmployed = false;
double weight = 81.9;
Console.WriteLine($"Имя: {NAME}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работа: {isEmployed}");

    //Суффиксы F/f для float, M/m для decimal, U/u для uint, L/l для long, Ul/ul для ulong

float poi = 3.14f;
decimal boi = 200.7m;
uint gr = 30u;
long fl = 30l;
ulong st = 30ul;

var gm = "Good morning";  //неявная типизация через var
var tr = 34;


//КОНСОЛЬНЫЙ ВВОД-ВЫВОД

Console.Write("Your name: ");
string? nAme = Console.ReadLine();
Console.WriteLine("Good morning, \n" + nAme);

//Convert.ToInt32() преобразует к типу int
//Convert.ToDouble() преобразует к типу double
//Convert.ToDecimal() преобразует к типу decimal


//АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ

double w = 10;
double s = 3;
double ws = w / s;      //деление
Console.WriteLine(ws);

double e = 10;
double r = 3;
double er = e % r;      //нахождение остатка
Console.WriteLine(er);


//ПОРАЗРЯДНЫЕ ОПЕРАЦИИ

int x1 = 2; //010
int x2 = 5; //101
Console.WriteLine(x1 & x2); //0 логическое умножение

int x3 = 2; //010
int x4 = 5; //101
Console.WriteLine(x3 | x4); //111 (7) логическое сложение

int y1 = 45; //101101
int fay = 102; //1100110
int encrypt = y1 ^ fay; //1001011 (75) логическое исключающее
Console.WriteLine($"Зашифрованное число: {encrypt}");
int decrypt = encrypt ^ fay;
Console.WriteLine($"Расшифрованное число: {decrypt}");
int y6 = 12; //00001100

Console.WriteLine(~y6); //11110011 (-13) логическое отрицание (инверсия)
int y2 = 22;
int y3 = 2;
int y4 = y2 << y3; // сдвиг влево на разряд
Console.WriteLine($"Зашифрованное число: {y4}");
int y5 = y2 >> y3; //сдвиг вправо на разряд
Console.WriteLine($"Расшифрованное число: {y5}");


//ОПЕРАЦИИ ПРИСВАИВАНИЯ

int z1 = 10;    //10
z1 += 10;       //20
z1 -= 4;        //16
z1 *= 2;        //32
z1 /= 8;        //4
z1 <<= 4;       //64
a >>= 2;        //16


//ПРЕОБРАЗОВАНИЯ БАЗОВЫХ ТИПОВ ДАННЫХ

byte ay = 6;
int by = ay + 90;

    //byte ay = 6;              - выдаст ошибку
    //byte by = ay + 90;        - операции + и - возвращают значения типа int, если переменная byte, int, short. Int занимает 4 байта, а для byte надо 1 байт.

byte au = 6;
byte bu = (byte)(au + 90);

//byte преобразуется в short, ushort, int, uint, long, ulong, float, double, decimal
//sbyte преобразуется в short, int, long, float, double, decimal
//short преобразуется в int, long, float, double, decimal
//ushort преобразуется в int, uint, long, ulong, float, double, decimal
//int преобразуется в long, float, double, decimal
//uint преобразуется в long, ulong, float, double, decimal
//long преобразуется в float, double, decimal
//ulong преобразуется в float, double, decimal
//float преобразуется в double
//char преобразуется в ushort, int, uint, long, ulong, float, double, decimal


//КОНСТРУКЦИЯ if..else И ТЕРНАРНАЯ ОПЕРАЦИЯ

int w1 = 9278;
int w2 = 2429;
if (w1 > w2)
{
    Console.WriteLine($"Число {w1} больше {w2}");
}
else if (w2 > w1)
{
    Console.WriteLine($"Число {w2} больше {w1}");
}
if (w1 > w2 && w1==9278)
{
    Console.WriteLine($"Число {w1} больше {w2}");
}
else
{
    Console.WriteLine("Числа равны");
}

//ЗАДАЧА

Console.Write("Введите число для определения первого пальца: ");
int f1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для определения второго пальца: ");
int f2 = Convert.ToInt32(Console.ReadLine());