namespace RPGBattleSimulatorApp;

class Mage : Character
{
    public Mage() : base(10, 3)
    {

    }

    public override void Attack(Character opponent)
    {
        Console.WriteLine("Attack mage.");
        opponent.Health - = AttackPower;
        if(opponent.Health < 0 ) opponent.Health = 0;
    }
}