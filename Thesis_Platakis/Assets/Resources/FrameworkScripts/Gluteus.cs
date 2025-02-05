using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Gluteus : Muscle
{
    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.Find("OneSkeleton_Reference").GetComponent<Body>();
        thr = GameObject.Find("OneSkeleton_Reference").GetComponent<Thresholds>();
        name = "Gluteus";
        tma = GameObject.Find("OneSkeleton_Reference").GetComponent<TextureMuscleActivator>();
        jointsToEvaluate = new GameObject[2];
        thresholds = new float[2, 2];
        /* 
        here add the joints that need to be evaluated for this muscle eg.:
        jointsToEvaluate[0] = body.bodyparts["RLeg"];
        jointsToEvaluate[1] = body.bodyparts["LLeg"];

        and then add the thresholds of this joints for the activation of the muscle eg.:
        thresholds[0, 0] = thr.thresholds[name][0];
        thresholds[0, 1] = thr.thresholds[name][1];
        thresholds[1, 0] = thr.thresholds[name][0];
        thresholds[1, 1] = thr.thresholds[name][1];
        */
    }

    // Update is called once per frame
    void Update()
    {
        tma.Evaluate(jointsToEvaluate, thresholds);
    }
}
