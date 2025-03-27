using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        //컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 함
        Queue queue = new Queue();

        //후단에 새 요소 추가
        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }

        //현재 큐에 저장된 요소의 개수
        Debug.Log($"Queue Count : {queue.Count}");

        //전단의 요소를 삭제하지 않고 반환
        Debug.Log($"현재 0번 요소 : {queue.Peek()}");
        Debug.Log($"Queue Count : {queue.Count}");

        //전단의 요소를 삭제하고 반환
        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");

        Debug.Log($"Queue Count : {queue.Count}");

        //큐의 모든 요소 삭제
        queue.Clear();
        Debug.Log($"Queue Count : {queue.Count}");

    }
}
