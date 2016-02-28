using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EmployeeManager.DataAccess
{
    public class BaseRepository<T>
    {
        private readonly string _dbPath;
        protected List<T> DbSet { get; set; }

        public BaseRepository(string fileName)
        {
            _dbPath = Path.Combine(Application.StartupPath, "DataAccess", "Db", fileName + ".json");
            DbSet = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(_dbPath));
        }

        public List<T> Get() { return DbSet; }

        public void Save(T record, int? index)
        {
            record = TransformBeforeSave(record);
            if (index.HasValue)
            {
                DbSet[index.Value] = record;
            }
            else
            {
                DbSet.Add(record);
            }

            SaveChanges();
        }

        public void Delete(T record)
        {
            DbSet.Remove(record);
            SaveChanges();
        }

        public void Delete(int index)
        {
            var record = DbSet[index];
            DbSet.Remove(record);
            SaveChanges();
        }

        private static T TransformBeforeSave(T record)
        {
            typeof(T).GetProperty(GenericProperties.ModifiedAt).SetValue(record, DateTime.UtcNow);
            var id = typeof(T).GetProperty(GenericProperties.Id).GetValue(record);

            if (id != null) return record;
            typeof(T).GetProperty(GenericProperties.CreatedAt).SetValue(record, DateTime.UtcNow);
            typeof(T).GetProperty(GenericProperties.Id).SetValue(record, DateTime.UtcNow.ToString(CultureInfo.InvariantCulture));

            return record;
        }

        private void SaveChanges()
        {
            File.WriteAllText(Path.Combine(Application.StartupPath, _dbPath),
                JsonConvert.SerializeObject(DbSet, Formatting.Indented));
        }
    }
}
