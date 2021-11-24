using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPermissionSystem
{
    public class UAPManager
    {
        // interface for database connection
        private IGerneralDAO _dao;


        /// <summary>
        /// generates a new UAPManager with the database connection interface
        /// </summary>
        /// <param name="gerneralDAO">Interface for the database connsection</param>
        public UAPManager(IGerneralDAO gerneralDAO)
        {
            _dao = gerneralDAO;
        }
    }
}
