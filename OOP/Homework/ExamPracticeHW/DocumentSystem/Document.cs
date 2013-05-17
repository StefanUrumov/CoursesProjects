using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }

        public string Content { get; protected set; }

        private readonly IList<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();

        public void LoadProperty(string key, string value)
        {
            properties.Add(new KeyValuePair<string, object>(key, value));
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output = properties;
        }
    }
}
