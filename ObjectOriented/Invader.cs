﻿using System;
namespace TreehouseDefense
{
    abstract public class Invader : IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);
        //computed property, properites always return a value

        public abstract int Health { get; protected set; }

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);
       
        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an invader");
        }
    }
} 