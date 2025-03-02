using System.Diagnostics;

public class TimerService
{
    private Stopwatch stopwatch;

    public TimerService()
    {
        stopwatch = new Stopwatch();
    }

    public int GetSeconds()
    {
        return stopwatch.Elapsed.Seconds;
    }

    public void StartTimer()
    {
        stopwatch.Start();
    }

    public void StopTimer()
    {
        stopwatch.Stop();
    }
}
