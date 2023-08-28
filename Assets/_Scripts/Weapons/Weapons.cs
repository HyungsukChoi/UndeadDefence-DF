using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour, IAttackable
{
    public bool isAttack = false;

    public float weaponLv;
    public float weaponAtt;

    //��Ÿ�
    public float AttackRange;
    public float AttackDelay;
    public LayerMask enemyLayer;

    float setTime = 0;

    public virtual void AttackEnemy()
    {// ���̾� ����
       
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, AttackRange, enemyLayer);

        if (enemies.Length > 0)
        {
            isAttack = true;
        }
        else
        {
            isAttack = false;
        }

        //Debug.Log(isAttack);
    // ����
     if (isAttack == true)
        {// �Ӹ�������
            if (enemies[0].gameObject.GetComponent<Transform>().position.x <= gameObject.GetComponent<Transform>().position.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
                
            setTime += Time.deltaTime;
            if (AttackDelay <= setTime)
            {
                // EffectPos.gameObject.SetActive(true);
                Debug.Log("hit");
                // Instantiate(ShotEffect, EffectPos);
                enemies[0].gameObject.SendMessage("Damaged", weaponAtt);
                Debug.Log(enemies[0].gameObject.GetComponent<Monster>().hp);
                setTime = 0f;
            }
        }
    }

    public void weaponLvUp()
    {
        weaponAtt += 3;
        AttackDelay -= 0.03f;
    }
}
