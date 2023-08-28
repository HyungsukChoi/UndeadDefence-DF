using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SickleParams : WeaponParams
{
    public override void WParms()
    {
        weaponCode = 1;
        isAttack = false;
        WeaponLv = 1;
        range = 2.5f;
        att = 10f;
        speed = 10f;
        attDelay = 0.5f;
    }

    public override void WeaponLvUp()
    {   
        base.WeaponLvUp();
    }
}
