﻿
using ADO.NET_Example;


string connectionString = "Server = DESKTOP-SU7UN5F\\SQLEXPRESS ; Database=CSharpPractice1 ; User Id = CSharpPractice1 ;Password = 123456;";
DataUtility dataUtility = new DataUtility(connectionString);

var sql = "update Students set Cgpa = 3.94 where id = 4";
//var sql = "delete from Students where id = 4";
//dataUtility.ExecuteCommand(sql);

var query = "Select * from Students";

var values = dataUtility.ExecuteQuery(query);

foreach (var value in values)
{
    foreach (var item in value.Keys)
    {
        Console.Write($" {item} : {value[item]} ");
    }        
    Console.WriteLine();
}


