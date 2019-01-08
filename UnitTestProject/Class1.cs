using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Data
{
    public class DBVersion
    {
        [PrimaryKey]
        public string ID
        {
            get
            {
                return "DBVersion";
            }
            set
            {

            }
        }

        public LocationEnum Loaction { get; set; }

        public int Version { get; set; }

    }

    public enum LocationEnum
    {
        Inner = 0,
        External = 1
    }


}
