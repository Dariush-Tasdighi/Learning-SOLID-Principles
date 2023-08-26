// Best Practice:
//
// Single Responsibility Principle (SRP)

namespace Application.Step_0200;

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

public class OrderSaver : object
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
	public OrderService(Order order) : base()
	{
		Order = order;

		OrderSaver = new(order: order);
		OrderNotifier = new(order: order);
		OrderValidator = new(order: order);
	}

	public Order Order { get; }
	public OrderSaver OrderSaver { get; }
	public OrderNotifier OrderNotifier { get; }
	public OrderValidator OrderValidator { get; }

	public void Process()
	{
		OrderValidator.Validate();
		OrderSaver.Save();
		OrderNotifier.Notify();

		//if (OrderValidator.Validate())
		//{
		//	if (OrderSaver.Save())
		//	{
		//		OrderNotifier.Notify();
		//	}
		//}
	}
}
