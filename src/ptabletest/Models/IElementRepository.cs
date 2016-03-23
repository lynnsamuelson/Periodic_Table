using System;
using System.Collections.Generic;

namespace ElementApi.Models
{
   
    public interface IElementRepository
    {
        void Add(AtomicElement atom);
        IEnumerable<AtomicElement> GetAll();
        AtomicElement Find(string key);
        AtomicElement Remove(string key);
        void Update(AtomicElement atom);
    }
}
