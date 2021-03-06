﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payer.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        protected static DatabaseContext _db;
        private static object _lock = new object();
        protected RepositoryBase()
        {
            CreateContext();
        }

        public static DatabaseContext CreateContext()
        {
            if (_db == null)
            {
                lock (_lock)
                {
                    if (_db == null)
                    {
                        _db = new DatabaseContext();
                    }
                }
                
            }

            return _db;
        }
    }
}
