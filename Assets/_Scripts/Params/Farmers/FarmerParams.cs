using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerParams : MonoBehaviour
{
    // ���밪 ����
    public bool selected { get; set; }
    public int attMax { get; set; }
    public int attMin { get; set; }
    public float attDistance { get; set; }

    public virtual void InitParams()  //�ڱ� �ڽ��� ��ɾ� �߰�
    {

    }
    // ������ ����
    public int GetRandomAttack()
    {
        int randAtt = Random.Range(attMin, attMax);
        return randAtt;
    }
}

