using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Doc : Person
    {
        string profession;
        Queue<Patient> work = new Queue<Patient>();
        Dictionary<DateTime, Patient> q = new Dictionary<DateTime, Patient>();
        public Doc(string name, string srname, string login, string password, string profession, string otchestvo = "") : base(name, srname, login, password, otchestvo)
        {
            this.profession = profession;
        }
    }
}
