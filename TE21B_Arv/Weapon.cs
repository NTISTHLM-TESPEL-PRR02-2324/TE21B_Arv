public class Weapon
{
  public int damage;
  public string name;

  public virtual int Attack()
  {
    Console.WriteLine("Attackerar med whatever");
    return Random.Shared.Next(damage);
  }
}
