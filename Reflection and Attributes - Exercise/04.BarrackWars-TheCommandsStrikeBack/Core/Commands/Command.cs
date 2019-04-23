﻿using _04.BarrackWars_TheCommandsStrikeBack.Contracts;

namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Commands
{
    public abstract class Command:IExecutable
    {
        protected Command(string[]data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data { get;  private set; }

        protected IRepository Repository { get; private set; }

        protected IUnitFactory UnitFactory { get; private set; }

        public abstract string Execute();
    }
}
