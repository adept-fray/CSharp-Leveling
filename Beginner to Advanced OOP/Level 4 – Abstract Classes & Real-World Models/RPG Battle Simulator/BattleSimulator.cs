namespace RPGBattleSimulatorApp;

class BattleSimulator
{
    public void StartBattle(Character player1, Character player2)
    {
        Console.WriteLine($"Battle starts: player1 vs player2\n");

        int turn = 1;

        while((player1.Health > 0) && (player2.Health > 0))
        {
            Console.WriteLine($"-- Turn {turn} --");

            if (turn % 3 == 0)
            {
                player1.Attack(player2);
            }

            if (player2.Health == 0) break;

            if (turn % 4 == 0)
            {
                player2.Attack(player1);
            }

            Console.WriteLine($"player1 HP: {player1.Health} | player2 HP: {player2.Health}\n");
            turn++;
            Thread.Sleep(1000);
        }

        string winner = player1.Health > 0 ? "player1" : "player2";
        Console.WriteLine($"\n🏆 {winner} wins the battle!");
    }
}