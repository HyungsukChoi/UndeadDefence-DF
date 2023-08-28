using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachWeapon : MonoBehaviour
{
    GameObject weaponPrefab;
    // 캔버스에서 무기 선택시 WeaponPos에 무기장착

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Attach()
    {// 캔버스에서 무기 선택시 WeaponPos에 무기장착
        
        Instantiate(weaponPrefab, transform);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
