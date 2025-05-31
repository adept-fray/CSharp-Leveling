namespace RPGBattleSimulatorApp;

Console.WriteLine("RPG Battle Simulator");


Character warrior = new Warrior();
Character mage = new Mage();

BattleSimulator simulator = new BattleSimulator();
simulator.StartBattle(warrior, mage);