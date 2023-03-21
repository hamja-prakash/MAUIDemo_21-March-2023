using MAUISampleDemo.Model;
using SQLite;
using System.Collections.ObjectModel;

namespace MAUISampleDemo
{
    public class Database
    {
        private SQLiteAsyncConnection _database;
        private readonly string _databasePath;
        private async Task Init()
        {
            if (_database != null)
            {
                return;
            }

            var options = new SQLiteConnectionString(_databasePath, true, "password", postKeyAction: c =>
            {
                c.Execute("PRAGMA cipher_compatibility = 3");
            });
            _database = new SQLiteAsyncConnection(options);
            await _database.CreateTableAsync<Person>();
            await _database.CreateTableAsync<Student>();
        }

        public Database(string dbPath)
        {
            _databasePath = dbPath;
        }

        #region [Person Data ]
        public async Task<List<Person>> GetPeopleAsync()
        {
            await Init();

            return await _database.Table<Person>().ToListAsync();
        }

        public async Task<int> SavePersonAsync(Person person)
        {
            await Init();

            return await _database.InsertAsync(person);
        }

        public async Task<int> UpdatePersonAsync(Person person)
        {
            await Init();

            return await _database.UpdateAsync(person);
        }

        public async Task<int> DeletePersonAsync(Person person)
        {
            await Init();

            return await _database.DeleteAsync(person);
        }

        public async Task<List<Person>> QueryEmployeeAsync()
        {
            await Init();

            return await _database.QueryAsync<Person>("SELECT * FROM Person WHERE IsPSSPLEmployee = true");
        }

        public async Task<List<Person>> LinqNotEmployeeAsync()
        {
            await Init();

            return await _database.Table<Person>().Where(p => p.IsPSSPLEmployee == false).ToListAsync();
        }
        #endregion

        #region [ Student Data ]
        public async Task<List<Student>> GetStudentAsync()
        {
            await Init();
            return await _database.Table<Student>().ToListAsync();
        }

        public async Task<int> SaveStudentAsync(Student Student)
        {
            await Init();
            return await _database.InsertAsync(Student);
        }

        public async Task<int> UpdateStudentAsync(Student Student)
        {
            await Init();
            return await _database.UpdateAsync(Student);
        }

        public async Task<int> DeleteStudentAsync(Student Student)
        {
            await Init();
            return await _database.DeleteAsync(Student);
        } 
        #endregion
    }
}
