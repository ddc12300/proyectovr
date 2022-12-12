using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovementBotonv2: MonoBehaviour {

public BotonTriggerv2 dt;


void Update()

{

if(dt.openTrigger ){
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;
        motor.targetVelocity = 50;
        hinge.motor = motor;
        
}else{
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;
        motor.targetVelocity = -35;
        hinge.motor = motor;
}

}

}
