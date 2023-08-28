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

    // �������� �ؽ�Ʈ ǥ��
    public void StageLv()
    {
        stage.text = $"Stage : {stageLv}";

    }
    // �������� ������ư
    public void OnClickUpButton()
    {
        // ��ȭ ���
        // �������� �״�� alert ��ȭ�� �����մϴ�.
        stageLv++;
        StageLv();
        // ��ȯ�Ǵ� ���� ����+
        MonsterSpawner.Instance.MonsterID++;
    }

    // �������� ���ҹ�ư
    public void OnClickDownButton()
    {
        // ��ȭ ���
        // �������� �״��
        stageLv--;
        
        StageLv();
        //��ȯ�Ǵ� ���� ����-
        MonsterSpawner.Instance.MonsterID--;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
