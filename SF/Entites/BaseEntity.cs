﻿using SF.Entites.Interfaces;
namespace SF.Entites
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get;  set; }
    }
}
