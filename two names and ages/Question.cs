using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_names_and_ages
{
   class Question
    
    {
        public string quest;
        public Question(string Q)
        {
            quest = Q;
        }
        public string response()
        {
            string response;
            Console.Write (quest + "-");
            response = Console.ReadLine ();
            return response;
        }
    }

}

