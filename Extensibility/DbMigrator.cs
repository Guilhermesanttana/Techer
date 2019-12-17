using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            //Details of migration the database

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
