Console.WriteLine("Flawlessly executed!");
PeriodicTimer timer = new(TimeSpan.FromSeconds(1)); 
Console.WriteLine("Initialized timer");
Console.WriteLine("Waiting for next tick...");
Console.Equals(timer.WaitForNextTickAsync().Result, true);

