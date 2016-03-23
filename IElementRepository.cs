using System;
using System.Collections.Generic;

namespace ElementApi.Models
{
   
    public interface IElementRepository
    {
        void Add(Element item);
        IEnumerable<Element> GetAll();
        Element Find(string key);
        Element Remove(string key);
        void Update(Element item);
    }
}
