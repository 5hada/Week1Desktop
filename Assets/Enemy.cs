using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//������(upcasting)
public class Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"�� : {damage}��ŭ ü�� ����");
    }
}
public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"��� : {damage}��ŭ ü�� ����");
    }
}
public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"������ : {damage}��ŭ ü�� ����");
    }
}
public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"�巡�� : {damage}��ŭ ü�� ����");
    }
}

