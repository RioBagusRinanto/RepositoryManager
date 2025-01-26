using System;
using System.Collections.Generic;

namespace RepositoryManagerLibrary
{
    public class RepositoryManager
    {
        private readonly Dictionary<string, (string content, int type)> _repository = new Dictionary<string, (string, int)>();
        private bool _isInitialized = false;

        public void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
            }
        }

        public void Register(string itemName, string itemContent, int itemType)
        {
            if (itemType == 1) // JSON
            {
                if (!IsValidJson(itemContent))
                {
                    throw new ArgumentException("Invalid JSON format.");
                }
            }
            else if (itemType == 2) // XML
            {
                if (!IsValidXml(itemContent))
                {
                    throw new ArgumentException("Invalid XML format.");
                }
            }
            else
            {
                throw new ArgumentException("Invalid item type.");
            }

            if (_repository.ContainsKey(itemName))
            {
                throw new InvalidOperationException("Item already exists in the repository.");
            }

            _repository[itemName] = (itemContent, itemType);
        }

        public string Retrieve(string itemName)
        {
            if (!_repository.ContainsKey(itemName))
            {
                throw new KeyNotFoundException("Item not found.");
            }

            return _repository[itemName].content;
        }

        public int GetType(string itemName)
        {
            if (!_repository.ContainsKey(itemName))
            {
                throw new KeyNotFoundException("Item not found.");
            }

            return _repository[itemName].type;
        }

        public void Deregister(string itemName)
        {
            if (!_repository.ContainsKey(itemName))
            {
                throw new KeyNotFoundException("Item not found.");
            }

            _repository.Remove(itemName);
        }

        private bool IsValidJson(string content)
        {
            return content.StartsWith("{") && content.EndsWith("}");
        }

        private bool IsValidXml(string content)
        {
            return content.StartsWith("<") && content.EndsWith(">");
        }
    }
}
