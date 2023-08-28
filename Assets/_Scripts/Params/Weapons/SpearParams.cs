using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearParams : WeaponParams
{
    public override void WParms()
    {
        weaponCode = 1;
        isAttack = false;
        WeaponLv = 1;
        range = 3f;
        att = 15f;
        speed = 10f;
        attDelay = 0.7f;
    }

    public override void WeaponLvUp()
    {   
        base.WeaponLvUp();
    }
}
