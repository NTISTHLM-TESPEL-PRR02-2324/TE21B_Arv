public class Axe : Weapon
{
  public Axe()
  {
    damage = 10;
    name = "Axe";
  }

  public void Grind()
  {
    damage++;
  }

  public override int Attack()
  {
    Console.WriteLine("Attackerar med yxa");
    return 2 + Random.Shared.Next(damage);
  }
}
