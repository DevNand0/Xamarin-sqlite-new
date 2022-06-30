using SQLite;
using SqliteCreateList.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqliteCreateList.Data
{
    public class DataBase
    {
        private readonly SQLiteAsyncConnection _database;
        public DataBase(string path) 
        {
            _database = new SQLiteAsyncConnection(path);
            _database.CreateTableAsync<Models.Person>();
        }


        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }

    }
}
