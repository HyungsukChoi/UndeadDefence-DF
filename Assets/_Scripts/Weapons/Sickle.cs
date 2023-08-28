using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sickle : Weapons
{
    SickleParams sickleParams;
    private void Start()
    {
        sickleParams = GetComponent<SickleParams>();

        weaponLv = 1;
        weaponAtt = sickleParams.att;
        AttackDelay = sickleParams.attDelay;
        AttackRange = sickleParams.range;
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
