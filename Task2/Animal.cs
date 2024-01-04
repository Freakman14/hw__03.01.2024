public abstract class Animal
{
    public string Name;

    public void SetName(string name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }
    public virtual void Eat() { }
    
}