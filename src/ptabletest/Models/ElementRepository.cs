using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ElementApi.Models
{
    public class ElementRepository :IElementRepository
    {
        static ConcurrentDictionary<string, AtomicElement> _element = new ConcurrentDictionary<string, AtomicElement>();

        public ElementRepository()
        {
            Add(new AtomicElement { Name = "Element1" });
        }

        public IEnumerable<AtomicElement> GetAll()
        {
            return _element.Values;
        }

        public void Add(AtomicElement item)
        {
            item.Key = Guid.NewGuid().ToString();
            _element[item.Key] = item;
        }

        public AtomicElement FindElement(string key)
        {
           AtomicElement item;
            _element.TryGetValue(key, out item);
            return item;
        }

        public AtomicElement Remove(string key)
        {
            AtomicElement item;
            _element.TryGetValue(key, out item);
            _element.TryRemove(key, out item);
            return item;
        }

        public void Update(AtomicElement item)
        {
            _element[item.Key] = item;
        }

        public AtomicElement Find(string key)
        {
            throw new NotImplementedException();
        }
    }
}