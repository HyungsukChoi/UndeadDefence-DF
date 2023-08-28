using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu]
public class SortGrade : ScriptableObject
{
    public int index;
    public static SortGrade instance;
    public int count = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    [System.Serializable]
    public class Grades
    {
        
        public FarmerGrade grade;
        public int weight;
     }

    public List<Grades> grades = new List<Grades>();


    protected FarmerGrade sortGrade()
    {
        int sum = 0;
        foreach (var grade in grades)
        {
            sum += grade.weight;
        }

        var rnd = Random.Range(0, sum);

        for (int i = 0; i < grades.Count; i++)
        {
            var grade = grades[i];
            if (grade.weight > rnd) return grades[i].grade;
            else rnd -= grade.weight;
        }
        return null;
    }
    
    public void InstanceRandomGrades()
    {
        Vector3 pos = GameObject.Find("FarmerSpawnPoint").transform.position;
        var grade = sortGrade();
        //grade내의 shader로만 변경
        // 등급 내의 프리펩 소환
        Instantiate(grade.prefab, pos, Quaternion.identity);
        DataManager.instance.farmerData.prefab = grade.prefab;

        DataManager.instance.AddFarmer(grade.prefab, count);

        // Debug.Log(count);
        count++;
    }
}
