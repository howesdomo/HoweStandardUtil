using SQLite;

namespace Util.Data_SQLite
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
                // Private Set
            }
        }

        public LocationEnum Loaction { get; set; }

        public int Version { get; set; }
    }
}
