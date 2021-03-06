﻿using System.Collections.Generic;
using System.Linq;

namespace Integration.ToDo.Models
{
    public class ToDoStore
    {
        public IEnumerable<ToDoItem> Items { get; set; }

        public ToDoStore()
        {
            Items = Enumerable.Empty<ToDoItem>();
        }
    }
}