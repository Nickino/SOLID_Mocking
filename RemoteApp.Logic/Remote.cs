namespace RemoteApp.Logic
{
    public class Remote
    {
        private IDevice Device { get; set; }
        public Remote(IDevice device, int numberOfChannels)
        {
            this.Device = device;
        }
        public void ToggolePower()
        {
            if(Device.IsOn())
            {
                Device.TurnOff();
            }
            else
            {
                Device.TurnOn();
            }
        }

        public void VolumeUp(int increment)
        {
            if(Device.IsOn())
            {
                Device.VolumeUp(increment);
            }
        }
    }
}