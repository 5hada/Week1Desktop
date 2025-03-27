using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableExercise : MonoBehaviour
{
    private void Awake()
    { 
        //new로 메모리 할당
        Hashtable hash = new Hashtable();

        //컬렉션은 object타입을 저장하기에 클래스 인스턴스도 저장 가능
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        //요소 추가([]연산자)
        hash["Goblin"] = goblin;

        //요소 추가(Add메서드)
        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요", "문자열");

        //HashTable, Dicionary 등 for문으로 순차적 데이터 접근이 불가능할 때의 반복문 사용
        //foreach ( 데이터타입 변수명 in 배열 등 데이터집합)
        foreach(object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        //해시테이블에 "Slime"키가 존재하는지 확인
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime 키 존재");
        }

        //해시테이블에 "goblin"값이 존재하는지 확인
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"goblin 값 존재");
        }

        //해시테이블에 저장된 요소 개수
        Debug.Log($"HashTable Count : {hash.Count}");

        //해시테이블에서 입력된 매개변수 "Slime"키를 가진 요소 삭제
        hash.Remove("Slime");

        //해시테이블에 저장된 요소 개수
        Debug.Log($"HashTable Count : {hash.Count}");

        //해시테이블의 모든 요소 삭제
        hash.Clear();

        //해시테이블에 저장된 요소 개수
        Debug.Log($"HashTable Count : {hash.Count}");
    }   
}
