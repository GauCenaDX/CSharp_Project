

// Yes - 2, 18, 2854, -9
// No - 1.2, -5.7

// Two billion +/-
// signed Int32
// unsigned - 4 billion
// bit - 0 or 1
// byte - 8 bits - 00000100 (4)
// 1 (1), 11 (3), 111 (7)
// Adding one more bit will double the size

int age = 0;
age = 43;

int ageInTenYears = age + 10;

Console.WriteLine($"My current age is: {age}.");
Console.WriteLine($"In ten years, I will be {ageInTenYears}.");

// Don't divide int
Console.WriteLine($"Half of my age is: {age / 2}. It got rounded down.");

Console.ReadLine();