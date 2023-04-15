

// 4.12, 32, 1.234 - Double
// 4,12, 32, 1.234 - Decimal - 16 bytes

// Int32 - 00000000 00000000 00000000 00000001 (1)

// M signals it is a Decimal data type
decimal bankAccountBalance = 2.34M;

Console.WriteLine(bankAccountBalance);

Console.ReadLine();
