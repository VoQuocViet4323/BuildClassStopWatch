public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;
    public StopWatch()
    {
        startTime = DateTime.Now;
    }
    public DateTime StartTime
    {
        get { return startTime; }
    }
    public DateTime EndTime
    {
        get { return endTime; }
    }
    public void Start()
    {
        startTime = DateTime.Now;
    }
     public void Stop()
    {
        endTime = DateTime.Now;
    }
    public double GetElapsedTime()
    {
        TimeSpan elapsedTime = endTime - startTime;
        return elapsedTime.TotalMilliseconds;
    }
}