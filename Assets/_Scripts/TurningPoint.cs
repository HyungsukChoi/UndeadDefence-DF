using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningPoint : MonoBehaviour
{
    public static Transform[] turningPoints;
    private void Awake()
    {
        turningPoints = new Transform[transform.childCount];
        for(int index = 0; index < turningPoints.Length; index++)
        {
            turningPoints[index] = transform.GetChild(index);
        }
    }
}
