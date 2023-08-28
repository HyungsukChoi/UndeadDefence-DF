using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : Weapons
{
    ShovelParams shovelParams;

    private void Start()
    {
        shovelParams = GetComponent<ShovelParams>();

        weaponLv = 1;
        weaponAtt = shovelParams.att;
        AttackDelay = shovelParams.attDelay;
        AttackRange = shovelParams.range;
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
