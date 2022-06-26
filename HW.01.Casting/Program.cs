byte @byte = 20;
sbyte @sbyte = 30;

// неявное преобразование
short @short1 = @sbyte;
short @short2 = @byte;
ushort @ushort = @byte;
int @int1 = @ushort;
int @int2 = @short1;
uint @uint = @ushort;
long @long1 = @int1;
long @long2 = @uint;
double @double = @long1;
decimal @decimal = @long2;

// явное преобразование
@double = (double)@decimal;
@long1 = (long)@double;
@long2 = (long)@double;
@uint = (uint)@long1;
@int1 = (int)@uint;
@int2 = (int)@uint;
@ushort = (ushort)@int1;
@short1 = (short)@int2;
@sbyte = (sbyte)@short1;
@byte = (byte)@ushort;

// boxing, unboxing            
object @object = 123m;         //boxing
@decimal = (decimal)@object;   //unboxing

@object = 123d;                //boxing
@double = (double)@object;     //unboxing...

@object = 123l;
@long1 = (long)@object;

@object = 123l;
@long2 = (long)@object;

@object = 123u;
@uint = (uint)@object;

@object = 123;
@int1 = (int)@object;

@object = 124;
@int2 = (int)@object;

@object = (ushort)123;
@ushort = (ushort)@object;

@object = (short)123;
@short1 = (short)@object;

@object = (short)124;
@short2 = (short)@object;



