using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WeaponControl : MonoBehaviour
{
    public static WeaponControl instance;
    
    public GameObject[] weaponPrefabs;
    public Transform weaponPos;
    public Transform activeButtonTr;
    public int weaponCode;
    // 무기위치 자식리스트
    Transform[] weaponPosChildList;
    // 버튼 자식리스트
    Transform[] weaponButtonChildList;
    // Start is called before the first frame update

    //선택버튼
    private void Awake()
    {
        if(instance == null)
        { instance = this; }

        weaponButtonChildList = activeButtonTr.GetComponentsInChildren<Transform>();
        for (int i = 1; i < weaponButtonChildList.Length; i++)
        {
            weaponButtonChildList[i].gameObject.SetActive(false);
        }

        weaponPosChildList = weaponPos.GetComponentsInChildren<Transform>();
        for (int i = 1; i < weaponPosChildList.Length; i++)
        {
            weaponPosChildList[i].gameObject.SetActive(false);
        }
    }

    private void Start()
    {
       
    }


    public void OnClickShovel()
    {
        ResetWeapon();
        ChangeWeapon(0);
        DataManager.instance.farmerData.WeaponCode = 0;
    }

    public void OnClickSpear()
    {
        ResetWeapon();
        ChangeWeapon(1);
        DataManager.instance.farmerData.WeaponCode = 1;
    }

    public void OnClickSicklel()
    {
        ResetWeapon();
        ChangeWeapon(3);
        DataManager.instance.farmerData.WeaponCode = 3;
    }

    public void OnClickGun()
    {
        ResetWeapon();
        ChangeWeapon(2);
        DataManager.instance.farmerData.WeaponCode = 2;
    }

    public void OnClickSelectWeapon()
    {
        // 무기선택버튼 활성화
        if (weaponButtonChildList != null)
        {
            for (int i = 1; i < weaponButtonChildList.Length; i++)
            {
                weaponButtonChildList[i].gameObject.SetActive(true);
            }
        }
    }

    // 무기 변경
    public void ChangeWeapon(int weaponNumber)
    {
        weaponPrefabs[weaponNumber].SetActive(true);
        // 버튼끄기 
        for(int i = 1; i < weaponButtonChildList.Length; i++)
        weaponButtonChildList[i].gameObject.SetActive(false);
    }

    // 무기 리셋
    void ResetWeapon()
    {
        if (weaponPosChildList != null)
        {
            for (int i = 1; i < weaponPosChildList.Length; i++)
            {
                weaponPosChildList[i].gameObject.SetActive(false);
            }
        }
    }
}
