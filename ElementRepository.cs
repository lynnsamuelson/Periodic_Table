using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ElementApi.Models
{
    public class ElementRepository : IElementRepository
    {
        static ConcurrentDictionary<string, Element> _element = new ConcurrentDictionary<string, Element>();

        public ElementRepository()
        {
            Add(new Element { Name = "Element1" });
        }

        public IEnumerable<Element> GetAll()
        {
            return _element.Values;
        }

        public void Add(Element item)
        {
            item.Key = Guid.NewGuid().ToString();
            _element[item.Key] = item;
        }

        public Element Find(string key)
        {
           Element item;
            _element.TryGetValue(key, out item);
            return item;
        }

        public Element Remove(string key)
        {
            Element item;
            _element.TryGetValue(key, out item);
            _element.TryRemove(key, out item);
            return item;
        }

        public void Update(Element item)
        {
            _element[item.Key] = item;
        }
    }
}