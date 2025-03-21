using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//다형성(upcasting)
public class Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"적 : {damage}만큼 체력 감소");
    }
}
public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : {damage}만큼 체력 감소");
    }
}
public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : {damage}만큼 체력 감소");
    }
}
public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : {damage}만큼 체력 감소");
    }
}

