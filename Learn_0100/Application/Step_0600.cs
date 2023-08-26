// Bad Practice:
//
// Liskov Substitution Principle (LSP)

namespace Application.Step_0600;

public class Bird : object
{
	public Bird() : base()
	{
	}

	public void Eat()
	{
	}

	public void Fly()
	{
	}
}

/// <summary>
/// قناری
/// </summary>
public class Canary : Bird
{
	public Canary() : base()
	{
	}
}

/// <summary>
/// شترمرغ
/// </summary>
public class Ostrich : Bird
{
	public Ostrich() : base()
	{
	}
}
