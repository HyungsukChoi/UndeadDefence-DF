using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachWeapon : MonoBehaviour
{
    GameObject weaponPrefab;
    // ĵ�������� ���� ���ý� WeaponPos�� ��������

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Attach()
    {// ĵ�������� ���� ���ý� WeaponPos�� ��������
        
        Instantiate(weaponPrefab, transform);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
