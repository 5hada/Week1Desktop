using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//������(upcasting)
public class GameController : MonoBehaviour
{
    private void Awake() //������ ���ݸ� ����
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
