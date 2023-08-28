using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerSpawn : MonoBehaviour
{
    public static FarmerSpawn instance;
    public SortGrade sortGrade;
    // ������ �ĸ� ������ ����
    public int count = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {

    }

    public void CharSpawn()
    { 
        sortGrade.InstanceRandomGrades();
    }

    public void OnClick()
    {
        CharSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
