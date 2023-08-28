using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : Enemies
{
    public static Monster Instance;
    public Image hpImage;

    
    private Transform turningPoint;
    private int turningPointIndex = 0;
    public float monsterSpeed = 5.0f;
    public GameObject damagedEffect;
    

    
    // float maxDistance = 10f;
   // Start is called before the first frame update
   

    private void Start()
    {
        turningPoint = TurningPoint.turningPoints[0];
    }

    public override void Damaged(float damage)
    {
        base.Damaged(damage);
        hpImage.GetComponent<Transform>().localScale = new Vector3((hp / maxHp), 1, 1);
        Instantiate(damagedEffect, transform);
    }

    
    //몬스터움직임
    void MonsterMove()
    {
        Vector2 dir = turningPoint.position - transform.position;
        transform.Translate(dir.normalized * Time.deltaTime * monsterSpeed, Space.World);

        if(Vector2.Distance(transform.position, turningPoint.position) <=0.2f)
        {
            GetNextWayPoint();
        }
    }

    // 다음 웨이포인트로 이동
    void GetNextWayPoint()
    {
        if(turningPointIndex >= TurningPoint.turningPoints.Length-1)
        {
            turningPointIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        turningPointIndex++;
        if (turningPointIndex == 3)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        turningPoint = TurningPoint.turningPoints[turningPointIndex];
    }
    
    // Update is called once per frame
    void Update()
    {
        MonsterMove();
    }
}
