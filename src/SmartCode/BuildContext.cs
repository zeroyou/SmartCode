﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartCode.Configuration;

namespace SmartCode
{
    public class BuildContext
    {
        public Project Project { get; set; }
        public IDataSource DataSource { get; set; }
        public String BuildKey { get; set; }
        public Build Build { get; set; }
        public String Result { get; set; }
        public String OutputName { get; set; }
        public object this[string key] { get { return Items[key]; } set { Items[key] = value; } }
        public IDictionary<String, object> Items { get; set; } = new Dictionary<String, object>();
        public TItem GetItem<TItem>(string key)
        {
            return (TItem)Items[key];
        }
        public void SetItem(string key, object item)
        {
            Items[key] = item;
        }
    }
}
