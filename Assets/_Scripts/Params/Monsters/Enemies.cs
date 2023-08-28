using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour, IDamagable
{/*
    private Transform turningPoint;
    private int turningPointIndex = 0;
    float monsterSpeed = 5.0f;
    // public GameObject damagedEffect;
    */
    public float maxHp;
    public float hp;
    public float damage;
    public bool dead;
    public float spawnDelay;

 
    private void Start()
    {
        // turningPoint = TurningPoint.turningPoints[0];
    }

    //몬스터움직임
    /*
    public virtual void MonsterMove()
    {
        Vector2 dir = turningPoint.position - transform.position;
        transform.Translate(dir.normalized * Time.deltaTime * monsterSpeed, Space.World);

        if (Vector2.Distance(transform.position, turningPoint.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }

    // 다음 웨이포인트로 이동
    public virtual void GetNextWayPoint()
    {
        if (turningPointIndex >= TurningPoint.turningPoints.Length - 1)
        {
            turningPointIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        turningPointIndex++;
        if (turningPointIndex == 3)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        turningPoint = TurningPoint.turningPoints[turningPointIndex];
    }
    */

    public virtual void Damaged(float damage)
    {
        hp -= damage;
        // Debug.Log(hp);
        // hit event 
        if(hp <= 0)
        {
            dead = true;
            OnDead();
        }
    }
     
    public virtual void OnDead()
    {
        dead = true;
        Destroy(gameObject);
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
