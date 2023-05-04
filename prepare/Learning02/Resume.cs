public class Resume{
    public string _firstName;
    public string _lastName;
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"{_firstName} {_lastName}");
        foreach (Job job in _jobs){
            job.Display();
        }
    }

}