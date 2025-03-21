using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//다형성(upcasting)
public class GameController : MonoBehaviour
{
    private void Awake() //동일한 공격만 가능
    {
        Player player = new Player();

        Enemy goblin = new Goblin();
        Enemy slime = new Slime();
        Enemy dragon = new Dragon();

        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);
    }
}
