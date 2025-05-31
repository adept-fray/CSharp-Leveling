namespace RPGBattleSimulatorApp;

class Warrior : Character
{
    public Warrior() : base(12, 2)
    {

    }

    public override void Attack(Character opponent)
    {
        Console.WriteLine("Attack Warrior.");
        opponent.Health - = AttackPower;
        if(opponent.Health < 0 ) opponent.Health = 0;
    }
}