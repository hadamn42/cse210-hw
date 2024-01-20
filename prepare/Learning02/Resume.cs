public class Resume
{
    public string _Name;
    public List<Job> _Jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_Name} \nJobs: ");
        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }

}