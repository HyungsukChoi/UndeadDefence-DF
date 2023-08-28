using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy0Params : MonsterParams
{
    public override void MParams()
    {
        maxHp = 100;
        Hp = maxHp;
        spawnDelay = 1;
    }
}
