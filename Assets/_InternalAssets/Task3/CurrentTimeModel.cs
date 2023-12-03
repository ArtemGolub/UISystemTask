using System;

public class CurrentTimeModel
{
    public int Hour { get; private set; }
    public int Minute { get; private set; }
    public int Second { get; private set; }

    public void UpdateTime()
    {
        DateTime now = DateTime.Now;
        Hour = now.Hour;
        Minute = now.Minute;
        Second = now.Second;
    }
}
