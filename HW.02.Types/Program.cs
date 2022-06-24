byte b1 = 10;
Byte b2 = 11;
Console.WriteLine(b1.GetType());
Console.WriteLine(b2.GetType()); 

sbyte sb1 = 25;
SByte sb2 = 26;
Console.WriteLine("\n" + sb1.GetType());
Console.WriteLine(sb2.GetType()); 

bool bo1 = true;
Boolean bo2 = true;
Console.WriteLine("\n" + bo1.GetType());
Console.WriteLine(bo2.GetType()); 

short s1 = 6500;
Int16 s2 = 6501;
Console.WriteLine("\n" + s1.GetType());
Console.WriteLine(s2.GetType()); 

ushort us1 = 2300;
UInt16 us2 = 2301;
Console.WriteLine("\n" + us1.GetType());
Console.WriteLine(us2.GetType()); 

char ch1 = 'a';
Char ch2 = 'b';
Console.WriteLine("\n" + ch1.GetType());
Console.WriteLine(ch2.GetType());

int i1 = 1_500_000_000;
Int32 i2 = 1_500_000_001;
Console.WriteLine("\n" + i1.GetType());
Console.WriteLine(i2.GetType());

uint u1 = 3_000_000_000;
UInt32 u2 = 3_000_000_001;
Console.WriteLine("\n" + u1.GetType());
Console.WriteLine(u2.GetType()); 

float f1 = 52.000001f;
Single f2 = 52.0000002f;
Console.WriteLine("\n" + f1.GetType());
Console.WriteLine(f2.GetType());

long l1 = 2_000_000_000_000;
Int64 l2 = 2_000_000_000_001;
Console.WriteLine("\n" + l1.GetType());
Console.WriteLine(l2.GetType()); 

ulong ul1 = 2_000_000_000_003;
UInt64 ul2 = 2_000_000_000_004;
Console.WriteLine("\n" + ul1.GetType());
Console.WriteLine(ul2.GetType()); 

double d1 = 2.00000000000001;
Double d2 = 2.00000000000002;
Console.WriteLine("\n" + d1.GetType());
Console.WriteLine(d2.GetType());

decimal de1 = 3.0000000000000000000000000001m;
Decimal de2 = 3.0000000000000000000000000002m;
Console.WriteLine("\n" + de1.GetType());
Console.WriteLine(de2.GetType());

object o1 = 354.3f;
Object o2 = 354.4f;
Console.WriteLine("\n" + o1.GetType());
Console.WriteLine(o2.GetType());

string st1 = "my string";
String st2 = "my String";
Console.WriteLine("\n" + st1.GetType()); 
Console.WriteLine(st2.GetType()); 
