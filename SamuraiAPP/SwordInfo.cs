﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class SwordInfo
    {
        public int Id { get; set; }
        public string TahunPembuatan { get; set; }
        public string Nama { get; set; }
        public Samurai Samurai { get; set; }
        public string Berat { get; set; }
    }
}
