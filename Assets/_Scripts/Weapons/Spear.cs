using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapons
{
    SpearParams spearParams;
    private void Start()
    {
        spearParams = GetComponent<SpearParams>();

        weaponLv = 1;
        weaponAtt = spearParams.att;
        AttackDelay = spearParams.attDelay;
        AttackRange = spearParams.range;
    }

    public override void AttackEnemy()
    {
        base.AttackEnemy();
    }

    void Update()
    {
        AttackEnemy();
    }
}
