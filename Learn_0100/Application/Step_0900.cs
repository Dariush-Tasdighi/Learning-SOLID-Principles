// Best Practice:
//
// Interface Segregation Principle (ISP)

namespace Application.Step_0900;

public class OrderValidator : object
{
	public OrderValidator(Order order)
	{
		Order = order;
	}

	public Order Order { get; }

	public bool Validate()
	{
		return true;
	}
}

/// <summary>
/// New
/// </summary>
public interface IOrderSaver
{
	bool Save();
}

/// <summary>
/// New
/// </summary>
public interface IOrderReader
{
	Order? GetById(int id);

	public System.Collections.Generic.IList<Order>? GetAll();
}

/// <summary>
/// New
/// </summary>
public interface IOrderRemover
{
	bool DeleteById(int id);
}

/// <summary>
/// New
/// </summary>
public class OrderSaver : object, IOrderSaver, IOrderReader, IOrderRemover
{
	public OrderSaver(Order order)
	{
		Order = order;
	}

	public Order Order { get; }

	public bool Save()
	{
		return true;
	}

	public Order? GetById(int id)
	{
		return null;
	}

	public System.Collections.Generic.IList<Order>? GetAll()
	{
		return null;
	}

	public bool DeleteById(int id)
	{
		return true;
	}
}

/// <summary>
/// New
/// </summary>
public class CacheOrderSaver : object, IOrderSaver, IOrderReader
{
	public CacheOrderSaver(Order order)
	{
		Order = order;
	}

	public Order Order { get; }

	public bool Save()
	{
		return true;
	}

	public Order? GetById(int id)
	{
		return null;
	}

	public System.Collections.Generic.IList<Order>? GetAll()
	{
		return null;
	}
}

public class OrderNotifier : object
{
	public OrderNotifier(Order order)
	{
		Order = order;
	}

	public Order Order { get; }

	public void Notify()
	{
	}
}

public class OrderService : object
{
	public OrderService(Order order, IOrderSaver orderSaver) : base()
	{
		Order = order;
		OrderSaver = orderSaver;
		OrderNotifier = new(order: order);
		OrderValidator = new(order: order);
	}

	public Order Order { get; }
	public IOrderSaver OrderSaver { get; }
	public OrderNotifier OrderNotifier { get; }
	public OrderValidator OrderValidator { get; }

	public void Process()
	{
		OrderValidator.Validate();
		OrderSaver.Save();
		OrderNotifier.Notify();
	}
}
