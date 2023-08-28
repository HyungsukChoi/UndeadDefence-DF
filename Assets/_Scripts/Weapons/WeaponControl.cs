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
    // ������ġ �ڽĸ���Ʈ
    Transform[] weaponPosChildList;
    // ��ư �ڽĸ���Ʈ
    Transform[] weaponButtonChildList;
    // Start is called before the first frame update

    //���ù�ư
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
        // ���⼱�ù�ư Ȱ��ȭ
        if (weaponButtonChildList != null)
        {
            for (int i = 1; i < weaponButtonChildList.Length; i++)
            {
                weaponButtonChildList[i].gameObject.SetActive(true);
            }
        }
    }

    // ���� ����
    public void ChangeWeapon(int weaponNumber)
    {
        weaponPrefabs[weaponNumber].SetActive(true);
        // ��ư���� 
        for(int i = 1; i < weaponButtonChildList.Length; i++)
        weaponButtonChildList[i].gameObject.SetActive(false);
    }

    // ���� ����
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
