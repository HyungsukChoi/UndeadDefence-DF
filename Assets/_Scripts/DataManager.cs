using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using System;

[System.Serializable]
public class FarmerData
{
    public GameObject prefab;

    public int FarmerNum;
    
    // 위치 transform.position
    public Vector2 FarmerPos;
    // 등급 1,2,3
    public string FarmerGrade;
    // 종류 B,G,M,W
    public string FarmerType;
    // 장착한 무기
    public int WeaponCode;
}

public class FarmersData
{
    public FarmerData[] farmers = { };
    
    // public List<FarmerData> farmers = new List<FarmerData>();
}

[System.Serializable]
public class WeaponData
{
    // 무기레벨
    public int WeaponLv;
    // 무기 공격력
    public int WeaponAtt;
    // 무기 타입
    public int WeaponType;
    // 무기 사거리
    public float WeaponRange;
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public WeaponData nowWeapon = new WeaponData();

    //farmerdata 파머
    public FarmersData farmersData;

    public FarmerData farmerData;
    public FarmerData newFarmer;



    string path;
    string filename = "Farmer";
    string filename2 = "Weapon";


    private void Awake()
    {
        #region Singleton
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        #endregion
        path = Application.persistentDataPath + "/";
    }

   

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddFarmer(GameObject prefab, int num)
    {
        newFarmer = new FarmerData();
        newFarmer.prefab = prefab;
        newFarmer.FarmerNum = num;
        // newFarmer.FarmerPos = pos;

        string jsonNewFarmer = JsonUtility.ToJson(newFarmer);
        File.WriteAllText(path + filename + num, jsonNewFarmer);
    }

    public void SaveFarmerPos(int farmerNum, Vector2 pos)
    {
        string jsonnewfarmer = File.ReadAllText(path + filename + farmerNum);
        newFarmer = JsonUtility.FromJson<FarmerData>(jsonnewfarmer);

        newFarmer.FarmerPos = pos;

        string jsonNewFarmer = JsonUtility.ToJson(newFarmer);
        File.WriteAllText(path + filename + farmerNum, jsonNewFarmer);
    }

    public void SaveData()
    {
        string jsonWeapon = JsonUtility.ToJson(nowWeapon);
        string jsonFarmer = JsonUtility.ToJson(farmerData);

        File.WriteAllText(path + filename, jsonFarmer);
        File.WriteAllText(path + filename2, jsonWeapon);
    }

    

    public void LoadData()
    {
        if (File.ReadAllText(path + filename) != null)
        {
            string jsonFarmer = File.ReadAllText(path + filename);
            // string jsonWeapon = File.ReadAllText(path + filename2);

            farmerData = JsonUtility.FromJson<FarmerData>(jsonFarmer);
            // nowWeapon = JsonUtility.FromJson<WeaponData>(jsonWeapon);
        }
    }

    public void LastDamage()
    {
        
    }
    

    public void ReInstantiate()
    {

        for (int i = 0; i < 7; i++)
        {
            string jsonfarmer = File.ReadAllText(path + filename + i);
            newFarmer = JsonUtility.FromJson<FarmerData>(jsonfarmer);

            if (newFarmer.prefab != null)
            {
                Instantiate(newFarmer.prefab, transform);
                newFarmer.prefab.transform.position = newFarmer.FarmerPos;
            }
        }
        /*
        if (farmerData.prefab != null)
        {
            Instantiate(farmerData.prefab, transform);
            Debug.Log(farmerData.FarmerPos);
            farmerData.prefab.transform.position = farmerData.FarmerPos;

            switch(farmerData.WeaponCode)
            {
                case 0:
                    WeaponControl.instance.OnClickShovel();
                    break;
                case 1:
                    WeaponControl.instance.OnClickSpear();
                    break;
                case 2:
                    WeaponControl.instance.OnClickGun();
                    break;
                case 3:
                    WeaponControl.instance.OnClickSicklel();
                    break;
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
