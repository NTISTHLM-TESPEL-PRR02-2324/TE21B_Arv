public class Warrior
{
  public Sword sword;
  public Axe axe;

  public int Attack()
  {
    if (sword != null)
    {
      return sword.Attack();
    }
    if (axe != null)
    {
      return axe.Attack();
    }

    return 0;
  }
}
