using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableExercise : MonoBehaviour
{
    private void Awake()
    { 
        //new�� �޸� �Ҵ�
        Hashtable hash = new Hashtable();

        //�÷����� objectŸ���� �����ϱ⿡ Ŭ���� �ν��Ͻ��� ���� ����
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        //��� �߰�([]������)
        hash["Goblin"] = goblin;

        //��� �߰�(Add�޼���)
        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���", "���ڿ�");

        //HashTable, Dicionary �� for������ ������ ������ ������ �Ұ����� ���� �ݺ��� ���
        //foreach ( ������Ÿ�� ������ in �迭 �� ����������)
        foreach(object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        //�ؽ����̺� "Slime"Ű�� �����ϴ��� Ȯ��
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime Ű ����");
        }

        //�ؽ����̺� "goblin"���� �����ϴ��� Ȯ��
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"goblin �� ����");
        }

        //�ؽ����̺� ����� ��� ����
        Debug.Log($"HashTable Count : {hash.Count}");

        //�ؽ����̺��� �Էµ� �Ű����� "Slime"Ű�� ���� ��� ����
        hash.Remove("Slime");

        //�ؽ����̺� ����� ��� ����
        Debug.Log($"HashTable Count : {hash.Count}");

        //�ؽ����̺��� ��� ��� ����
        hash.Clear();

        //�ؽ����̺� ����� ��� ����
        Debug.Log($"HashTable Count : {hash.Count}");
    }   
}
