﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.BLL
{
    internal class userBll
    {
        public int id { get; set; }
        public string ssd { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public DateTime added_date { get; set; }
    }
}