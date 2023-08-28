using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapons
{
    // raycast 발사 hit시 데미지
    // Start is called before the first frame update
    GunParams gunParams;
    public GameObject ShotEffect;
    public Transform EffectPos;

    // gun 애니메이터
    Animator gunAnim;

    void Start()
    {
        gunParams = GetComponent<GunParams>();

        weaponLv = 1;
        weaponAtt = gunParams.att;
        AttackDelay = gunParams.attDelay;
        AttackRange = gunParams.range;
    }
 
    public override void AttackEnemy()
    {
        
        base.AttackEnemy();
    }
    
    // Update is called once per frame
    void Update()
    {
        AttackEnemy();
     }
}
