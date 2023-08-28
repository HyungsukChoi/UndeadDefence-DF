using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public static MonsterSpawner Instance;
    public GameObject[] monsterPrefabs;
    public Transform spawnPoint;

    Transform[] maxMonster;
    // �ִ� ���� ����
    public int maxCount = 50;
    public int waveCount = 50;
    public int MonsterID = 0;
    float setTime = 0;

    private void Awake()
    {
        if (MonsterSpawner.Instance == null)
            MonsterSpawner.Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    
    // ���ѵ� �� ��ŭ ���� ��ȯ
    void InstantiateLimit()
    {
        maxMonster = GetComponentsInChildren<Transform>();
        for (int i = 0; i <= waveCount; i++)
        {
            if (maxMonster.Length == maxCount)
            {
                StopCoroutine(SpawnMonster(MonsterID));
            }

            else
            {
                StartCoroutine(SpawnMonster(MonsterID));
            }
        }
    }

    // monsterCode : �������� - ���� ���

    IEnumerator SpawnMonster(int monsterCode)
    {
        setTime += Time.deltaTime;
        if(monsterPrefabs[monsterCode].GetComponent<Monster>().spawnDelay <= setTime)
        {
            Instantiate(monsterPrefabs[monsterCode], spawnPoint);
            setTime = 0;

            // Debug.Log(maxMonster.Length);
        }
        yield return new WaitForSeconds(0);
    }

    // Update is called once per frame

    void Update()
    {
        InstantiateLimit();
    }
}
