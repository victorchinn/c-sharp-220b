
using FinalProjectDB;

namespace FinalProjectRepository
{
    public class DatabaseManager
    {
        private static readonly FinalProjectDBContext entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new FinalProjectDBContext();
        }

        // Provide an accessor to the database
        public static FinalProjectDBContext Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
