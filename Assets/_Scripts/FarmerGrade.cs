using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/FarmerGrade", order = 1)]
public class FarmerGrade : ScriptableObject
{
    // ���
    public int grade;
    public GameObject prefab;
    // ��޺� ����
    public Shader shader;
}
