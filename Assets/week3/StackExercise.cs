using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    public void Awake()
    {
        //new로 메모리 할당
        Stack stack = new Stack();

        //스택의 최상위에 데이터 추가
        for (int i = 0; i < 5; ++i )
        {
            stack.Push(i);
        }

        //스택에 저장된 요소의 개수
        Debug.Log($"Stack Count : {stack.Count}");

        //스택의 최상위 데이터를 삭제하지 않고 반환
        Debug.Log($"마지막에 추가된 요소 : {stack.Peek()}");

        Debug.Log($"Stack Count : {stack.Count}");

        //스택의 최상위 데이터를 삭제하고 반환
        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");

        Debug.Log($"Stack Count : {stack.Count}");

        //스택의 모든 요소 삭제
        stack.Clear();

        Debug.Log($"Stack Count : {stack.Count}");

    }
}
