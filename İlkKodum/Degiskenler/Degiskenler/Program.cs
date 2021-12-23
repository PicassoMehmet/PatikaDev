byte b = 3;
sbyte sb = 2;

short s = 10;
ushort us = 20;

Int16 i16 = 12;
int i = 2;
Int32 i32 = 4;
Int64 i64 = 8;

uint u = 16;
long l = 10;
ulong ul = 20;

//Reel Sayılar
float f = 2;
double d = 10;
decimal c = 10;

char ch = 'a';
string str = "Str";

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x";
object o2 = "y";
object o3 = 3;
object o4 = 4.2;

//String İfadeler

string str1 = string.Empty;
str1 = "Furkan Acer";
string ad = "Furkan";
string soyad = "Acer";
string tamisim = ad + " " + soyad;

// İnteger tanımlama şekilleri 

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

//boolean

bool booll = 10 > 2;

//Değişken Dönüşümleri

string str20 = "20";
int int20 = 20;
string YeniDeger = str20 + int20.ToString();
Console.WriteLine(YeniDeger);

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22);

//Date-Time

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);