﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex
{
    public class TestDbContext : DbContext       // here inherit DbContext base class class from Microsoft.EntityFrameworkCore
    {
        private string _connectionString;

        private string _assemblyName;
        public DbSet<Student> Students { get; set; }     //using DbSet<Student> generic class  here, Student class connect with DbContext class . 

        public TestDbContext()
        {
            _connectionString = "Server = DESKTOP-SU7UN5F\\SQLEXPRESS; Database = CSharpPractice2; User Id = CSharpPractice2; Password = 123456;";
            /*
                Assembly.GetExecutingAssembly() is .NET method from Reflection namespace , thats provides static methods.
                it's Assembly of running project . Assembly.GetExecutingAssembly().FullName provide here FullName of Assembly .
                Assembly means .exe/.dll file that's exist in project 
            */
            _assemblyName = Assembly.GetExecutingAssembly().FullName;

            //Console.WriteLine($"Assembly.GetExecutingAssembly().FullName : {Assembly.GetExecutingAssembly().FullName}");

            // Assembly.GetExecutingAssembly().FullName : EntityFramework_Ex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullAssembly.GetExecutingAssembly().FullName : EntityFramework_Ex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
        }

        /*
            OnConfiguring method configuring database connection with Entity Framework .
            
            DbContextOptionsBuilder  Provides a simple API surface for configuring DbContextOptions. 
        */
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString,m=>m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder); // override some code from base class .  
        } 
    }
}
