using System;

// Base class
class Club
{
    // Protected fields
    protected string name;
    protected int members;
    protected string location;

    // Default constructor
    public Club()
    {
        name = "";
        members = 0;
        location = "";
    }

    // Parameterized constructor
    public Club(string name, int members, string location)
    {
        this.name = name;
        this.members = members;
        this.location = location;
    }

    // Get and set methods for protected fields
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetMembers()
    {
        return members;
    }

    public void SetMembers(int members)
    {
        this.members = members;
    }

    public string GetLocation()
    {
        return location;
    }

    public void SetLocation(string location)
    {
        this.location = location;
    }

    // methods to modify and display data
    public virtual void AddChangeData(string name, int members, string location)
    {
        SetName(name);
        SetMembers(members);
        SetLocation(location);
    }

    public virtual void DisplayData()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Members: {members}");
        Console.WriteLine($"Location: {location}");
    }
}

// Derived class
class SoccerClub : Club
{
    // Protected fields
    protected int numberOfPlayers;
    protected string coach;

    // Default constructor
    public SoccerClub() : base()
    {
        numberOfPlayers = 0;
        coach = "";
    }

    // Parameterized constructor
    public SoccerClub(string name, int members, string location, int numberOfPlayers, string coach) : base(name, members, location)
    {
        this.numberOfPlayers = numberOfPlayers;
        this.coach = coach;
    }

    // Get and set methods for protected fields
    public int GetNumberOfPlayers()
    {
        return numberOfPlayers;
    }

    public void SetNumberOfPlayers(int numberOfPlayers)
    {
        this.numberOfPlayers = numberOfPlayers;
    }

    public string GetCoach()
    {
        return coach;
    }

    public void SetCoach(string coach)
    {
        this.coach = coach;
    }

    // Override base class methods
    public override void AddChangeData(string name, int members, string location)
    {
        base.AddChangeData(name, members, location);
        Console.WriteLine("Enter the number of players:");
        numberOfPlayers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name of the coach:");
        coach = Console.ReadLine();
    }

    public override void DisplayData()
    {
        base.DisplayData();
        Console.WriteLine($"Number of Players: {numberOfPlayers}");
        Console.WriteLine($"Coach: {coach}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Array of base class objects
        Club[] clubs = new Club[2];
        clubs[0] = new Club();
        clubs[1] = new Club();

        // Array of derived class objects
        SoccerClub[] soccerClubs = new SoccerClub[2];
        soccerClubs[0] = new SoccerClub();
        soccerClubs[1] = new SoccerClub();

        int choice;
        do
        {
            Console.WriteLine("1. Add/Change data for Club");
            Console.WriteLine("2. Display data for Club");
            Console.WriteLine("3. Add/Change data for Soccer Club");
            Console.WriteLine("4. Display data for Soccer Club");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter club name:");
                    string clubName = Console.ReadLine();
                    Console.WriteLine("Enter number of members:");
                    int clubMembers = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter club location:");
                    string clubLocation = Console.ReadLine();
                    clubs[0].AddChangeData(clubName, clubMembers, clubLocation);
                    break;
                case 2:
                    Console.WriteLine("Displaying data for Club:");
                    clubs[0].DisplayData();
                    break;
                case 3:
                    Console.WriteLine("Enter soccer club name:");
                    string soccerClubName = Console.ReadLine();
                    Console.WriteLine("Enter number of members:");
                    int soccerClubMembers = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter club location:");
                    string soccerClubLocation = Console.ReadLine();
                    soccerClubs[0].AddChangeData(soccerClubName, soccerClubMembers, soccerClubLocation);
                    break;
                case 4:
                    Console.WriteLine("Displaying data for Soccer Club:");
                    soccerClubs[0].DisplayData();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        } while (choice != 5);
    }
}
