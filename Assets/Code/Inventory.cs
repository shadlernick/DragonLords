using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;

namespace Creatures
{
	public class Inventory
	{
		public int Id { get; set; }
		public int OwnerId { get; set; }

		public Dictionary<IItem, int> Items { get; set; }

		private int _capacity;

		public Inventory()
		{
			_capacity = 50;
			Items = new Dictionary<IItem, int>();
		}

		public void AddItem(IItem item, int count)
		{
			if (Items.Count == _capacity)
				throw new InventoryException();

			Items.Add(item, count);
		}

		public void RemoveItem(IItem item)
		{
			Items.Remove(item);
		}

		public void Sort()
		{
            Items = (Dictionary<IItem, int>)Items.OrderBy(k => k.Key);
		}
	}

	public class InventoryException : Exception { }
}