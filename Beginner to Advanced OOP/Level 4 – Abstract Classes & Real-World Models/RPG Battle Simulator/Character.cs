namespace RPGBattleSimulatorApp;

abstract class Character
{
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Character(int health, int attackPower)
    {
        Health = health;
        AttackPower = attackPower;
    }


    public abstract void Attack();
}