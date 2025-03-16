using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class DataBaseContex : DbContext
    {
        public DbSet<TagData> Tags { get; set; }
        public DbSet<TagGroup> TagGroups { get; set; }

        public DbSet<DataEntry> DataEntrys { get; set; }
        public DbSet<EstimateValue> EstimateValues { get; set; }

        public string DbPath { get; }
        public DataBaseContex()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "accounting.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.EnableSensitiveDataLogging().UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll).UseSqlite($"Data Source={DbPath}");
        
    }
}
