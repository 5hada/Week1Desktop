using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        //�÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ��
        Queue queue = new Queue();

        //�Ĵܿ� �� ��� �߰�
        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }

        //���� ť�� ����� ����� ����
        Debug.Log($"Queue Count : {queue.Count}");

        //������ ��Ҹ� �������� �ʰ� ��ȯ
        Debug.Log($"���� 0�� ��� : {queue.Peek()}");
        Debug.Log($"Queue Count : {queue.Count}");

        //������ ��Ҹ� �����ϰ� ��ȯ
        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");

        Debug.Log($"Queue Count : {queue.Count}");

        //ť�� ��� ��� ����
        queue.Clear();
        Debug.Log($"Queue Count : {queue.Count}");

    }
}
