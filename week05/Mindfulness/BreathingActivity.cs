class BreathingActivity : Activity
{

    public BreathingActivity() :base("name", "description", 30)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        //do stuff

        DisplayEndingMessage();
    }
}