using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParams : MonoBehaviour
{
    // ���� �ڵ�
    public int weaponCode { get; set; }
    // ���� Ÿ�� 0 = �ܰŸ� 1 = ���Ÿ�
    public int weaponType { get; set; }
    // ���� Ÿ�� 0 = ���� 1 = ����
    public int attackType { get; set; }
    // ���� ����
    public bool isAttack { get; set; }
    // ���� ����
    public int WeaponLv { get; set; }
    // ���� ��Ÿ�(fixed)
    public float range { get; set; }
    // ���� ���ݷ�
    public float att { get; set; }
    // ���� �ӵ�
    public float speed { get; set; }
    // �߻� ����
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
            case 0: // �ܰŸ�

                break;
            case 1: // ���Ÿ�
                break;
        }
    }
    */
    // ���� Ÿ��
    /*
    public virtual void AttackType(int code)
    {
        switch (code)
        {
            case 0: // ����\
                for(int i = 0; i < enemies.Length; i++)
                {
                }
                break;
            case 1: // ����
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
        // ���ݷ� ����
        att += 0.5f * att * WeaponLv;
        // �߻� ������ ����
        attDelay -= attDelay * 0.1f;
    }
  
    /*
    public virtual void DetectEnemy()
    { // ���̾� ����
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
