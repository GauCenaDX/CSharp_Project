What is inheritance?

Inheritance is the idea of putting code into a class, and let another classes inherit those code that class.

The parent class and the child class has an "is a" relationship.

A Corolla is a Car
A Camry is a Car
A Tundra is not a Car. It's a truck. ==> should not inherit anything from Car.

A class should be in its own file. We should have more than one class in a file.

	- Program.cs
	- Car.cs
	- Camry.cs
	- Corolla.cs

A child class cannot inherit from more than one parent.

The purpose of inheritance is to allow us to extend something from something.

It is important to keep the "is a" rule when deciding to use inheritance. If we have two classes that need the same methods but they don't satisfy the "is a" relationship, don't use inheritance. Instead, we can break those methods out into a helper class and then call them in the other classes. That's way we are not repeating ourselves and also not violating inheritance.

Using inheritance, a child class can be used to fill in  for the parent class.

Phone phone = new Smartphone();

An example of using this is to have a list can can store different type of phones since they can all be used to Place Call and End Call.

We can check if phone is a Cellphone type and put it in a new variable called cell. This way we can access the other methods that a Cellphone type has.

	if (phone is Cellphone cell)

!PRO TIP!!!!
Inheritance seems like a magic cure but it is not. Use it sparingly and follow the "is a" rule.

