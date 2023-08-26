namespace Application;

// **************************************************
// Polymorphysm in Java:
//
//	- Method Overloading
//	- Method Overriding
// **************************************************

// **************************************************
// Polymorphysm in C#:
//
//	- Method Overloading
//	- Method Overriding
//	- Method Overhiding
// **************************************************

// **************************************************
public class Parent
{
	public void Eat()
	{
		System.Console.WriteLine("Parent Eats...");
	}
}

public class Child : Parent
{
}

public class SomeAnotherClass
{
	public void DoSomething()
	{
		Parent parent = new Parent();
		parent.Eat();
		// Parent Eats...

		Child child = new Child();
		child.Eat();
		// Parent Eats...

		// Up Castring
		Parent newParent = new Child();
		newParent.Eat();
		// Parent Eats...
	}
}
// **************************************************

// **************************************************
// Method Overriding
// **************************************************
//public class Parent
//{
//	public virtual void Eat()
//	{
//		System.Console.WriteLine("Parent Eats...");
//	}
//}

//public class Child : Parent
//{
//	public override void Eat()
//	{
//		System.Console.WriteLine("Child Eats...");
//	}
//}

//public class SomeAnotherClass
//{
//	public void DoSomething()
//	{
//		Parent parent = new Parent();
//		parent.Eat();
//		// Parent Eats...

//		Child child = new Child();
//		child.Eat();
//		// Child Eats...

//		// Up Castring
//		Parent newParent = new Child();
//		newParent.Eat();
//		// Child Eats...
//	}
//}
// **************************************************

// **************************************************
// Method Overhiding
// **************************************************
//public class Parent
//{
//	public void Eat()
//	{
//		System.Console.WriteLine("Parent Eats...");
//	}
//}

//public class Child : Parent
//{
//	public new void Eat()
//	{
//		System.Console.WriteLine("Child Eats...");
//	}
//}

//public class SomeAnotherClass
//{
//	public void DoSomething()
//	{
//		Parent parent = new Parent();
//		parent.Eat();
//		// Parent Eats...

//		Child child = new Child();
//		child.Eat();
//		// Child Eats...

//		// Up Castring
//		Parent newParent = new Child();
//		newParent.Eat();
//		// Parent Eats...
//	}
//}
// **************************************************
