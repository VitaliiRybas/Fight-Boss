Random rand = new Random();

int _health = 100;
int _healthBoss = 250;
int _damageGoust = 50;
int _damageSpell = 100;
int _damageBoss = rand.Next(35, 51);
int _regenerate = rand.Next(0, 20);

Console.WriteLine($"You have 100 HP, Boss - 250 HP. Boss have adds 35 to 50 damage");
Console.WriteLine("________________________________________________________________");

while (_health > 0 && _healthBoss > 0)
{
    Console.WriteLine("Select spell, press key ( 1 - 3 ): ");
    Console.WriteLine("1 - Rashamon (summons a ghost that deals 50 damage to the enemy)");
    Console.WriteLine("2 - Hackugara (100 damage to the enemy and 30 to the player)");
    Console.WriteLine("3 - Regenerate (Adds 0 to 20 health to the player, while taking no damage to the player)");
    string _spell = Console.ReadLine();
    
        switch (_spell)
        {
            case ("1"):
                _healthBoss = _healthBoss - _damageGoust;
                _health = _health - _damageBoss;
                Console.WriteLine($"You have {_health} - health, Boss have - {_healthBoss}");
                break;
            case ("2"):
                _healthBoss = _healthBoss - _damageSpell;
                _health = _health - 30;
                _health = _health - _damageBoss;
            Console.WriteLine($"You have {_health} - health, Boss have - {_healthBoss}");
            break;
            case ("3"):
                _health = _health + _regenerate;
            Console.WriteLine($"You have {_health} - health, Boss have - {_healthBoss}");
            break;
            default:
                Console.WriteLine("Press only key ( 1 - 3 )");
                break;
        }
}

if (_health == 0 && _healthBoss == 0)
{
    Console.WriteLine("Draw!");
}
else if (_health == 0)
{
    Console.WriteLine("Win enemy!");
}
else
{
    Console.WriteLine("You win!");
}
