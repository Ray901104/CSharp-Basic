namespace CSharp
{
    public class TextRPG2
    {
        static void Main(string[] args)
        {
            Player player = new Knight();
            Monster monster = new Orc();

            int damage = player.GetAttack();
            monster.OnDamaged(damage);
        }
    }
}