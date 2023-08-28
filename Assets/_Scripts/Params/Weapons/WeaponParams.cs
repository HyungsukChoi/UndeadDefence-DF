using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParams : MonoBehaviour
{
    // 무기 코드
    public int weaponCode { get; set; }
    // 무기 타입 0 = 단거리 1 = 원거리
    public int weaponType { get; set; }
    // 공격 타입 0 = 단일 1 = 범위
    public int attackType { get; set; }
    // 공격 여부
    public bool isAttack { get; set; }
    // 무기 레벨
    public int WeaponLv { get; set; }
    // 무기 사거리(fixed)
    public float range { get; set; }
    // 무기 공격력
    public float att { get; set; }
    // 공격 속도
    public float speed { get; set; }
    // 발사 간격
    public float attDelay { get; set; }


    void Start()
    {
        WParms();   
    }
    /*
    public virtual void WeaponType(int code)
    {
        switch(code)
        {
            case 0: // 단거리

                break;
            case 1: // 원거리
                break;
        }
    }
    */
    // 공격 타입
    /*
    public virtual void AttackType(int code)
    {
        switch (code)
        {
            case 0: // 단일\
                for(int i = 0; i < enemies.Length; i++)
                {
                }
                break;
            case 1: // 범위
                break;
        }
    }
    */

    public virtual void WParms()
    {
    }
    
    public virtual void WeaponLvUp()
    {
        WeaponLv++;
        // 공격력 증가
        att += 0.5f * att * WeaponLv;
        // 발사 딜레이 감소
        attDelay -= attDelay * 0.1f;
    }
  
    /*
    public virtual void DetectEnemy()
    { // 레이어 검출
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, range);

        if (enemies.Length > 0)
        {
            isAttack = true;
        }
        else
        {
            isAttack = false;
        }
    }

   public virtual void AttackEnemy()
    {
        DetectEnemy();
        if (isAttack == true)
        {
            float setTime = 0;
            setTime += Time.deltaTime;
            if (attDelay <= setTime)
            {
                Debug.Log(isAttack);
                setTime = 0f;
            }
        }
    }
    */
}
