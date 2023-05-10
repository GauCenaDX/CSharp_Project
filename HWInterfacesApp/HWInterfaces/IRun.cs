namespace HWInterfaces
{
    public interface IRun
    {
        int Distance { get; set; }
        int MaxSpeed { get; set; }

        void StartRunning();
        void StopRunning();
        void SpeedUp();
        void SlowDown();
    }
}


