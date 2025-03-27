using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        //new�� �޸� �Ҵ�
        ArrayList arrayList = new ArrayList();

        //��� �߰�(����)
        //objectŸ���̶� ���� ���� ������ ���� ����
        Debug.Log(arrayList.Add(10));
        //Debug.Log(arrayList.Add(10.0f));
        //Debug.Log(arrayList.Add("Hello"));

        //������ ���
        PrintArrayList(arrayList);

        //���ϴ� ��ġ�� ������ �߰�
        arrayList.Insert(1, 100);

        //������ ���
        PrintArrayList(arrayList);

        //��� �߰�(����, ICollection)
        Collection<int> data = new Collection<int>();

        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        //������ ���
        PrintArrayList(arrayList);

        //�Ű������� �Էµ� ������ ����
        arrayList.Remove(10);

        //������ ���
        PrintArrayList(arrayList);

        //�Ű������� �Էµ� ��ġ�� ������ ����
        arrayList.RemoveAt(0);

        //������ ���
        PrintArrayList(arrayList);

        //�Ű������� �Էµ� ������ ������ ����
        arrayList.RemoveRange(0, 2);

        //������ ���
        PrintArrayList(arrayList);

        //��� ��� ����
        arrayList.Clear();

        //��� ���� ���
        Debug.Log(arrayList.Count);
    }


    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("=====================================");

        for (int i = 0; i < list.Count; ++ i )
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }

}


