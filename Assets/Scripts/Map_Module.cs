using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Module : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("Player"))
        {
            Transform trans = transform;
            Sector._self.ToSelect();                // 배열 초기화
            Sector._self.TransPosition(trans);      // 이동 함수 호출
        }
    }
}
