﻿using CRUD_Demo.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Demo.Models
{
    public class User
    {
       [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set;}

        public override string ToString()
        {
            return this.Name + " ( " + this.Address + " ) ";
        }
    }
}
