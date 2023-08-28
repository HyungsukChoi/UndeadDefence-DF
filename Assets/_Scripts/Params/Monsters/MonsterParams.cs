using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterParams : MonoBehaviour
{
    UIManager uiManager;
    private void Start()
    {
        uiManager = GameObject.Find("MainUI").GetComponent<UIManager>();
        MParams();
    }

    public float spawnDelay { get; set; }
    public float Hp { get; set; }
    public float maxHp { get; set; }

    public virtual void MParams()
    {
    }

    public virtual void EnemyLvUp(int stageLv)
    {
        stageLv = uiManager.stageLv;
        Debug.Log(stageLv);
        maxHp += stageLv * 0.1f * maxHp;
        spawnDelay -= stageLv * 0.05f * spawnDelay;
    }
}
