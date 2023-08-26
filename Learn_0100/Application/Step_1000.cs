// Best Practice:
//
// Dependency Inversion Principle

namespace Application.Step_1000;

/// <summary>
/// New
/// </summary>
public interface IOrderValidator
{
	public bool Validate();
}

/// <summary>
/// New
/// </summary>
public class OrderValidator : object, IOrderValidator
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

public interface IOrderReader
{
	Order? GetById(int id);
}

public interface IOrderRemover
{
	bool DeleteById(int id);
}

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

	public bool DeleteById(int id)
	{
		return true;
	}
}

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
}

public interface IOrderNotifier
{
	void Notify();
}

public class OrderNotifier : object, IOrderNotifier
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
	public OrderService(Order order, IOrderValidator orderValidator,
		IOrderSaver orderSaver, IOrderNotifier orderNotifier) : base()
	{
		Order = order;
		OrderSaver = orderSaver;
		OrderNotifier = orderNotifier;
		OrderValidator = orderValidator;
	}

	public Order Order { get; }
	public IOrderSaver OrderSaver { get; }
	public IOrderNotifier OrderNotifier { get; }
	public IOrderValidator OrderValidator { get; }

	public void Process()
	{
		OrderValidator.Validate();
		OrderSaver.Save();
		OrderNotifier.Notify();
	}
}
