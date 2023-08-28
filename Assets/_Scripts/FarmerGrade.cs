using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/FarmerGrade", order = 1)]
public class FarmerGrade : ScriptableObject
{
    // 등급
    public int grade;
    public GameObject prefab;
    // 등급별 스텟
    public Shader shader;
}
