using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapons
{
    // raycast �߻� hit�� ������
    // Start is called before the first frame update
    GunParams gunParams;
    public GameObject ShotEffect;
    public Transform EffectPos;

    // gun �ִϸ�����
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
