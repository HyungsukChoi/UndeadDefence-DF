using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunParams : WeaponParams
{
    public override void WParms()
    {
        weaponCode = 2;
        isAttack = false;
        WeaponLv = 1;
        range = 4f;
        att = 10f;
        speed = 10f;
        attDelay = 0.5f;
    }

    public override void WeaponLvUp()
    {   
        base.WeaponLvUp();
    }
}
