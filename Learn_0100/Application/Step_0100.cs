// Bad Practice:
//
// Single Responsibility Principle (SRP)

namespace Application.Step_0100;

public class OrderService : object
{
	public OrderService() : base()
	{
	}

	public bool Validate(Order order)
	{
		return true;
	}

	/// <summary>
	/// Save Data (Order) in Database
	/// </summary>
	public bool Save(Order order)
	{
		return true;
	}

	/// <summary>
	/// Send SMS to User (Customer)
	/// </summary>
	public void SendNotification(Order order)
	{
	}
}
