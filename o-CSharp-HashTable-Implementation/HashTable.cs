using System;
using System.Collections.Generic;

namespace Exercises
{
    public class HashTable
    {
        private class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(int key, string value)
        {
            var index = hash(key);
            if (entries[index] == null)
            {
                entries[index] = new LinkedList<Entry>();
            }

            foreach (var item in entries[index])
            {
                if (item.key == key)
                {
                    item.value = value;
                    return;
                }
            }
            entries[index].AddLast(new Entry(key, value));
        }

        public string Get(int key)
        {
            var index = hash(key);
            var bucket = entries[index];
            if (bucket != null)
            {
                foreach (var entry in bucket)
                {
                    if (entry.key == key)
                    {
                        return entry.value;
                    }
                }
            }
            return null;
        }

        public void Remove(int key)
        {
            var index = hash(key);
            var bucket = entries[index];
            if (bucket == null)
            {
                throw new Exception("Key is not exist");
            }
            foreach (var entry in bucket)
            {
                if (entry.key == key)
                {
                    bucket.Remove(entry);
                    return;
                }
            }
        }

        private int hash(int key)
        {
            return key % entries.Length;
        }
    }
}