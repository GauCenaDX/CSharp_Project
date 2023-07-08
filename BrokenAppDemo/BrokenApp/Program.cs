﻿using BrokenLibrary;

CompanyCreator company = new();
int totalEmployees = 0;
int totalDaysOff = 0;

List<CompanyModel> companies = company.CreateCompanyList();

foreach (var c in companies)
{
    Console.WriteLine($"Company: { c.CompanyName }, Employees: { c.NumberOfEmployees }, Days Off: { c.NumberOfDaysOffTotal}, Average: { c.AverageDaysOff }");
    totalEmployees += c.NumberOfEmployees;
    totalDaysOff += c.NumberOfDaysOffTotal;
}

Console.WriteLine();

Console.WriteLine($"The total number of employees is { totalEmployees }");
Console.WriteLine($"The total number of days off is { totalDaysOff }");

Console.ReadLine();
