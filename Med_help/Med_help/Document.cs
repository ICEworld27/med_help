using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Document
    {
        int number;
        Person owner;
        DateTime time_of_issue;
        public Document(int number, Person owner, DateTime time_of_issue)
        {
            this.number = number;
            this.owner = owner;
            this.time_of_issue = time_of_issue;
        }
    }
}
