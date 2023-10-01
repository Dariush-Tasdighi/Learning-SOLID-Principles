// Bad Practice:
//
// Liskov Substitution Principle (LSP)

namespace Application.Step_0600;

public class Bird : object
{
	public Bird() : base()
	{
	}

	public virtual void Eat()
	{
	}

	public virtual void Fly()
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

	public override void Fly()
	{
		throw new System.NotImplementedException();
	}
}
