Console.WriteLine("-------------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("{0}{1,17}{2,23}{3,34}","Name","Size(Byte)","Min","Max");
Console.ResetColor();
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine($"sbyte    {sizeof(sbyte),8}{sbyte.MinValue,27}{sbyte.MaxValue,34}\n");
Console.WriteLine($"byte     {sizeof(byte),8}{byte.MinValue,27}{byte.MaxValue,34}\n");
Console.WriteLine($"short    {sizeof(short),8}{short.MinValue,27}{short.MaxValue,34}\n");
Console.WriteLine($"ushort   {sizeof(ushort),8}{ushort.MinValue,27}{ushort.MaxValue,34}\n");
Console.WriteLine($"int      {sizeof(int),8}{int.MinValue,27}{int.MaxValue,34}\n");
Console.WriteLine($"uint     {sizeof(uint),8}{uint.MinValue,27}{uint.MaxValue,34}\n");
Console.WriteLine($"long     {sizeof(long),8}{long.MinValue,27}{long.MaxValue,34}\n");
Console.WriteLine($"ulong    {sizeof(ulong),8}{ulong.MinValue,27}{ulong.MaxValue,34}\n");
Console.WriteLine($"float    {sizeof(float),8}{float.MinValue,27}{float.MaxValue,34}\n");
Console.WriteLine($"double   {sizeof(double),8}{double.MinValue,27}{double.MaxValue,34}\n");
//Console.WriteLine($"decimal  {sizeof(decimal),8}{decimal.MinValue,27}{decimal.MaxValue,34}");