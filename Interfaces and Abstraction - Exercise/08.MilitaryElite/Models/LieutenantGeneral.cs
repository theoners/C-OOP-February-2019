using System;
using System.Text;

namespace _08.MilitaryElite.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<Private> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }

        public IList<Private> Privates => this.privates.AsReadOnly();

        public void AddPrivate(Private currentPrivate)
        {
            this.privates.Add(currentPrivate);
        }

        public override string ToString()
        {
            var privatesInfo = new StringBuilder();
            privatesInfo.AppendLine("Privates:");

            foreach (var currentPrivate in privates)
            {
                privatesInfo.AppendLine("  "+currentPrivate);
            }
            return base.ToString()+Environment.NewLine+privatesInfo.ToString().TrimEnd();
        }
    }
}
