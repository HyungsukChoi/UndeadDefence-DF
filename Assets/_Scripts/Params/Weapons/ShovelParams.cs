using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelParams : WeaponParams
{
    public override void WParms()
    {
        weaponCode = 1;
        isAttack = false;
        WeaponLv = 1;
        range = 2f;
        att = 25f;
        speed = 10f;
        attDelay = 0.3f;
    }

    public override void WeaponLvUp()
    {   
        base.WeaponLvUp();
    }
}
