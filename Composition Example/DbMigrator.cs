using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_Example
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating bla bla");

        }
    }
}
