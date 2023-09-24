# SOLID_Mocking
CSCI5220 Mocking and SOLID
# SOLID and Mocking Principles in C#

This repository demonstrates the implementation of SOLID and Mocking principles in C#.

## SOLID Principles
- **Interface Segregation Principle (ISP)**: Make fine-grained interfaces that are client-specific.
- **Dependency Inversion Principle (DIP)**: Depend on abstractions, not on concretions.

## Mocking with NSubstitute
**Mocking** is an essential practice in software testing that allows developers to simulate specific behaviors of real objects. 
It's a way to isolate units of code and ensure that external factors don't interfere with tests. Various types of mock objects can be created based on the test requirements:

**Dummy objects**: Simply fill parameter lists.
**Fake objects**: Offer working implementations but may take shortcuts unsuitable for production.
**Stubs**: Provide canned answers for the test's specific calls.
**Spies**: Similar to stubs, but also record information based on their usage.
**Mocks**: Pre-programmed with expectations of the calls they should receive.

## NSubstitute
NSubstitute is a .NET mocking library that facilitates the creation of mock objects for interfaces and classes with overridable members.

## Basic Usage
**Creating Substitutes**:
IDevice device = Substitute.For<IDevice>();
**Asserting Method Calls**:
device.Received().TurnOn();
**Returning Values**:
device.IsOn().Returns(true);
**Checking a Method was NOT Called**:
device.DidNotReceive().TurnOn();
