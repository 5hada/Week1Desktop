using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//´ÙÇü¼º(upcasting)
public class Player : MonoBehaviour
{
    private int damage = 10;

    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }
}
