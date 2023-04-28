using System;
using SQLite;

namespace MeFacts_DB.Models
{
    public class PersonalItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageName { get; set; }
    }
}
