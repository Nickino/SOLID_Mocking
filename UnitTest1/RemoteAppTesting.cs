using NSubstitute;
using RemoteApp.Logic;

namespace UnitTest1;

public class ARemote
{
 
    [Test]
    public void CanToggleThePowerOfADeviceToTurnOn()
    {
        const int DONT_CARE_VALUE = 1; //This is a constant value that we don't care about
        IDevice device = Substitute.For<IDevice>(); //Create a substitute for the IDevice interface
        Remote sut = new(device, DONT_CARE_VALUE);
        //Act
        sut.ToggolePower(); // Turn on the device
        //Assert that received the call
        device.Received().TurnOn();
    }

    [Test]
    public void CanToggleThePowerOfADeviceToTurnOff()
    {
        const int DONT_CARE_VALUE = 1; //This is a constant value that we don't care about
        IDevice device = Substitute.For<IDevice>(); //Create a substitute for the IDevice interface
        Remote sut = new(device, DONT_CARE_VALUE);
        //Act
        sut.ToggolePower(); // Turn on the device
        sut.ToggolePower(); // Turn off the device
        //Assert that received the call
        device.Received(2).TurnOff();
    }

    [Test]
    public void CanToggleThePowerOfADeviceToTrnOff()
    {
        //Arrange - Create a substitute for the IDevice interface
        const int DONT_CARE_VALUE = 1; //This is a constant value that we don't care about
        IDevice device = Substitute.For<IDevice>(); //Create a substitute for the IDevice interface
        Remote sut = new(device, DONT_CARE_VALUE);
        device.IsOn().Returns(true);
        sut.ToggolePower(); // Turn off the device
        //Assert that received the call
        device.Received().TurnOff();
        //Assert that did not received the TurnOn() call
        device.DidNotReceive().TurnOn();
    }

    [Test]
    public void CanTurnUpTheVolumeOfTheDevice()
    {
        const int DONT_CARE_VALUE = 1; //This is a constant value that we don't care about
        IDevice device = Substitute.For<IDevice>(); //Create a substitute for the IDevice interface
        Remote sut = new(device, DONT_CARE_VALUE);
        device.IsOn().Returns(true);
        sut.VolumeUp(1);
        device.Received().VolumeUp(1);
    }
}