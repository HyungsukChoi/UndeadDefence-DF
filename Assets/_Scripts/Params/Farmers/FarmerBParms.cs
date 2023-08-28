using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerBParms : FarmerParams
{
    public override void InitParams()
    {
        selected = false;
        attMax = 10;
        attMin = 9;
        attDistance = 4f;
    }
}
