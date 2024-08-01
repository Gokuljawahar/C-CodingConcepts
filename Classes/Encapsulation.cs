using System;

class paitent
{
    private string bloodgroup;

    private string diagnosis;

    public string getBloodgroup()
    {
        return bloodgroup;
    }

    public void SetBloodgroup(string bg)
    {
        bloodgroup = bg;
    }

    public string Diagnosis
    {
        get { return diagnosis; }
        set { this.diagnosis = value; }
    }
}

class program
{
    public static void Main()
    {
        paitent p = new paitent();
        p.SetBloodgroup("b+ve");
        Console.WriteLine(p.Diagnosis = "chronic diease");
        Console.WriteLine(p.getBloodgroup());
    }
}
