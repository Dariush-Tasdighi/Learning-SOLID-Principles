// Best Practice:
//
// Open/Closed Principle (OCP)

namespace Application.Step_0400;

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
public class OrderSaver : object, IOrderSaver
{
	public OrderSaver(Order order)
	{
		Order = order;
	}

	public Order Order { get; }

	/// <summary>
	/// Save Data to Database
	/// </summary>
	public bool Save()
	{
		return true;
	}
}

/// <summary>
/// New
/// </summary>
public class CacheOrderSaver : object, IOrderSaver
{
	public CacheOrderSaver(Order order)
	{
		Order = order;
	}

	public Order Order { get; }

	/// <summary>
	/// Cache Data in Memory
	/// </summary>
	public bool Save()
	{
		return true;
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
	/// <summary>
	/// New
	/// </summary>
	public OrderService(Order order, IOrderSaver orderSaver) : base()
	{
		Order = order;

		OrderSaver = orderSaver;
		//OrderSaver = new(order: order);

		OrderNotifier = new(order: order);
		OrderValidator = new(order: order);
	}

	public Order Order { get; }

	public IOrderSaver OrderSaver { get; }
	//public OrderSaver OrderSaver { get; }

	public OrderNotifier OrderNotifier { get; }
	public OrderValidator OrderValidator { get; }

	public void Process()
	{
		OrderValidator.Validate();
		// New
		OrderSaver.Save();
		OrderNotifier.Notify();
	}
}
