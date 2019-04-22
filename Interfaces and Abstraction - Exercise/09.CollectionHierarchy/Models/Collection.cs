﻿namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;
    using Contracts;

    public abstract class Collection:IAddCollection
    {

        protected Collection()
        {
            this.Data =new List<string>();
        }
        protected List<string> Data { get;}

        public virtual int AddItem(string item)
        {
            this.Data.Insert(0,item);
            return 0;
        }
    }
}
