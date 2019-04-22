using System;
using System.Collections.Generic;
using System.Text;
using _08.MilitaryElite.Core;
using _08.MilitaryElite.Models;

namespace _08.MilitaryElite.Factories
{
   public class EngineerFactory
    {

        public Engineer CreateEngineer(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = decimal.Parse(args[4]);
            var corps = args[5];

            return new Engineer(id,firstName,lastName,salary,corps);
        }
    }
}
