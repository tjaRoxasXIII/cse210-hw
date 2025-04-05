class BreathingActivity : Activity
{

    public BreathingActivity() :base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30)
    {

    }

    public void Run()
    {
        int duration = this.GetDuration();
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe In...");
            this.ShowCountDown(4);

            Console.Clear();

            Console.WriteLine("Breathe Out...");
            this.ShowCountDown(6);

            currentTime = DateTime.Now;
        }
        

        DisplayEndingMessage();
    }
}