using System;

class Alarm
{
    // Task 1: Delegate
    public delegate void AlarmHandler();

    // Task 2: Event
    public event AlarmHandler OnAlarmTriggered;

    // Method to trigger the alarm
    public void TriggerAlarm()
    {
        Console.WriteLine("Alarm is triggered!");

        // Invoke the event (only if there are subscribers)
        OnAlarmTriggered?.Invoke();
    }
}

class Program
{
    // Task 3: Method to respond to alarm
    public static void RespondToAlarm()
    {
        Console.WriteLine("Warning! Take action immediately!");
    }

    static void Main(string[] args)
    {
        // Task 4: Create Alarm object
        Alarm alarm = new Alarm();

        // Subscribe method to event
        alarm.OnAlarmTriggered += RespondToAlarm;

        // Trigger the alarm
        alarm.TriggerAlarm();
    }
}