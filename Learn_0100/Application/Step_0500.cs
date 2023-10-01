// Best Practice:
//
// Open/Closed Principle (OCP)

namespace Application.Step_0500;

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

public interface IOrderSaver
{
	bool Save();
}

public class OrderSaver : object, IOrderSaver
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
}

public class CacheOrderSaver : object, IOrderSaver
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
	public OrderService(Order order, IOrderSaver[] orderSavers) : base()
	{
		Order = order;

		OrderSavers = orderSavers;

		OrderNotifier = new(order: order);
		OrderValidator = new(order: order);
	}

	public Order Order { get; }

	//public OrderSaver OrderSaver { get; }
	//public IOrderSaver OrderSaver { get; }
	public IOrderSaver[] OrderSavers { get; }

	public OrderNotifier OrderNotifier { get; }
	public OrderValidator OrderValidator { get; }

	public void Process()
	{
		OrderValidator.Validate();

		// New
		//OrderSaver.Save();

		foreach(var orderServer in OrderSavers)
		{
			orderServer.Save();
		}

		OrderNotifier.Notify();
	}
}
