using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        //new로 메모리 할당
        ArrayList arrayList = new ArrayList();

        //요소 추가(순차)
        //object타입이라 여러 종류 데이터 저장 가능
        Debug.Log(arrayList.Add(10));
        //Debug.Log(arrayList.Add(10.0f));
        //Debug.Log(arrayList.Add("Hello"));

        //데이터 출력
        PrintArrayList(arrayList);

        //원하는 위치에 데이터 추가
        arrayList.Insert(1, 100);

        //데이터 출력
        PrintArrayList(arrayList);

        //요소 추가(범위, ICollection)
        Collection<int> data = new Collection<int>();

        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        //데이터 출력
        PrintArrayList(arrayList);

        //매개변수에 입력된 데이터 삭제
        arrayList.Remove(10);

        //데이터 출력
        PrintArrayList(arrayList);

        //매개변수에 입력된 위치의 데이터 삭제
        arrayList.RemoveAt(0);

        //데이터 출력
        PrintArrayList(arrayList);

        //매개변수에 입력된 범위의 데이터 삭제
        arrayList.RemoveRange(0, 2);

        //데이터 출력
        PrintArrayList(arrayList);

        //모든 요소 삭제
        arrayList.Clear();

        //요소 개수 출력
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


