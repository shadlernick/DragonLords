using System;

public class Inventory
{
	public int Id { get; set; }
	public int OwnerId { get; set; }

	public List<IItem> Items { get; set; }

	private int _capacity;

	public Inventory()
	{

	}

	public void AddItem(int itemId, int count)
	{
		if (Items.Length == _capacity)
			throw new InventoryException();
	}

	public void RemoveItem();

	public void Sort();
}

public class InventoryException : Exception { }
