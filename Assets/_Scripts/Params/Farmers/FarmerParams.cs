using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerParams : MonoBehaviour
{
    // 공통값 정의
    public bool selected { get; set; }
    public int attMax { get; set; }
    public int attMin { get; set; }
    public float attDistance { get; set; }

    public virtual void InitParams()  //자기 자신의 명령어 추가
    {

    }
    // 데미지 계산식
    public int GetRandomAttack()
    {
        int randAtt = Random.Range(attMin, attMax);
        return randAtt;
    }
}

