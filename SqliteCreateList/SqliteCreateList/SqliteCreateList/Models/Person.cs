using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteCreateList.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Subscribed { get; set; }
    }
}
