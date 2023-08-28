using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;


public class Farmer : MonoBehaviour
{
    public int farmerNum;
    // Start is called before the first frame update

    void Start()
    {
        farmerNum = DataManager.instance.newFarmer.FarmerNum;
        // Debug.Log(farmerNum);
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }


    private void OnMouseUp()
    {
        // 자동 배치

        this.transform.position = new Vector2(Mathf.Floor(this.transform.position.x) + 0.5f, Mathf.Floor(this.transform.position.y) + 0.5f);
        DataManager.instance.farmerData.FarmerPos = this.transform.position;
        DataManager.instance.SaveFarmerPos(farmerNum, this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
