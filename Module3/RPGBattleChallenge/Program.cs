/*
    RPG Battle Challenge
    1. You must use either the do-while statement or the while statement as an outer game loop.
    2. The hero and the monster will start with 10 health points.
    3. All attacks will be a value between 1 and 10.
    4. The hero will attack first.
    5. Print the amount of health the monster lost and their remaining health.
    6. If the monster's health is greater than 0, it can attack the hero.
    7. Print the amount of health the hero lost and their remaining health.
    8. Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    9. Print the winner.
*/

int heroHealthPoints = 10;
int monsterHealthPoints = 10;

Random attackPower = new Random();

// do
// {
//     int heroAttackPower = attackPower.Next(1, 10);

//     monsterHealthPoints -= heroAttackPower;
//     Console.WriteLine($"Monster was damaged and lost {heroAttackPower} health and now has {monsterHealthPoints} health.");

//     if (monsterHealthPoints > 0)
//     {
//         int monsterAttackPower = attackPower.Next(1, 10);

//         heroHealthPoints -= monsterAttackPower;
//         Console.WriteLine($"Hero was damaged and lost {monsterAttackPower} health and now has {heroHealthPoints} health.");
//     }
//     else
//     {
//         winner = "Hero";
//         break;
//     }

// } while (heroHealthPoints > 0);

do
{
    int heroAttackPower = attackPower.Next(1, 10);
    monsterHealthPoints -= heroAttackPower;
    Console.WriteLine($"Monster was damaged and lost {heroAttackPower} health and now has {monsterHealthPoints} health.");

    if (monsterHealthPoints <= 0) continue;

    int monsterAttackPower = attackPower.Next(1, 10);
    heroHealthPoints -= monsterAttackPower;
    Console.WriteLine($"Hero was damaged and lost {monsterAttackPower} health and now has {heroHealthPoints} health.");
    
} while (heroHealthPoints > 0 && monsterHealthPoints > 0);

string winner = heroHealthPoints > monsterHealthPoints ? "Hero" : "Monster";
Console.WriteLine($"{winner} wins!");