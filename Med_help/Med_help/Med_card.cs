using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Med_card : Document
    {
        List<Ill> Ills = new List<Ill>();
        public Med_card(int number, Person owner, DateTime time_of_issue) : base(number, owner, time_of_issue)
        {

        }
    }
}
