// Best Practice:
//
// Liskov Substitution Principle (LSP)

namespace Application.Step_0700;

public class Bird : object
{
	public Bird() : base()
	{
	}

	public void Eat()
	{
	}
}

public class FlyingBird : Bird
{
	public FlyingBird() : base()
	{
	}

	public void Fly()
	{
	}
}

public class Canary : FlyingBird
{
	public Canary() : base()
	{
	}
}

public class Ostrich : Bird
{
	public Ostrich() : base()
	{
	}
}
