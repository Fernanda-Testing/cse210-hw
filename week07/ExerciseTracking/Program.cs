using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running rActivity = new Running("Running", new DateTime(2025, 3, 25), 50.0, 8.2);
        activities.Add(rActivity);
        Cycling cActitivy = new Cycling("Cycling", new DateTime(2025, 4, 15), 60, 25.0);
        activities.Add(cActitivy);
        Swimming sActivity = new Swimming("Swimming", new DateTime(2025, 2, 7), 30, 40);
        activities.Add(sActivity);

        foreach(Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
