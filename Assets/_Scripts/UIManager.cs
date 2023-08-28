using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    
    public static UIManager instance;
    public TMP_Text stage;
    public int stageLv = 1;
    // Start is called before the first frame update

      void Start()
    {
        StageLv();
    }

    // 스테이지 텍스트 표시
    public void StageLv()
    {
        stage.text = $"Stage : {stageLv}";

    }
    // 스테이지 증가버튼
    public void OnClickUpButton()
    {
        // 재화 사용
        // 돈없으면 그대로 alert 재화가 부족합니다.
        stageLv++;
        StageLv();
        // 소환되는 몬스터 레벨+
        MonsterSpawner.Instance.MonsterID++;
    }

    // 스테이지 감소버튼
    public void OnClickDownButton()
    {
        // 재화 사용
        // 돈없으면 그대로
        stageLv--;
        
        StageLv();
        //소환되는 몬스터 레벨-
        MonsterSpawner.Instance.MonsterID--;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
