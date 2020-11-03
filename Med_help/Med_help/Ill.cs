using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Ill
    {
        string discription;
        int period;
        bool question;
        public Ill(string discription, int period, bool question)
        {
            this.discription = discription;
            this.period = period;
            this.question = question;
        }
    }
}
