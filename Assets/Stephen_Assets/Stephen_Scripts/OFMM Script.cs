using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OFMMScript
{
    public int objectiveNumber;

    public string objectiveDescription;

    public bool objectiveCompleted;
    
    public OFMMScript(int on, string od, bool oc)
    {
        od = objectiveDescription;
        on = objectiveNumber;
        oc = objectiveCompleted;
    }

    
}
