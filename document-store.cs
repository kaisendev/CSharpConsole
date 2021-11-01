using System;
using System.Collections.Generic;

namespace DocumentStore
{

    public class DocumentStore
    {
        private readonly int _capacity;
        private readonly List<string> _documents = new List<string>();

        public DocumentStore(int capacity)
        {
            _capacity = capacity;
        }

        public List<string> Documents => _documents;

        public void AddDocument(string document)
        {
            if(_documents.Count >= _capacity)
            {
                throw new InvalidOperationException();
            }

            //_documents.Add(document);

            _documents.GetType().GetMethod("Add").Invoke(_documents, new[] { document });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentStore store = new DocumentStore(2);
            store.AddDocument("Item 1");
            store.AddDocument("Item 2");

            foreach (var item in store.Documents)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
