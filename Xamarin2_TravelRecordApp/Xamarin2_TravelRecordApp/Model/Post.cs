using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin2_TravelRecordApp.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Experience { get; set; }
    }
}
