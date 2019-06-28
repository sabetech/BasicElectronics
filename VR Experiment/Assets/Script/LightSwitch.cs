﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public TextMesh textStatusInfo;

    
    public enum SwitchState
    {
        on,
        off
    }

    public SwitchState switchState = SwitchState.off;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void actionPerformedOnClick()
    {
        if ( GetComponent<ElectricalComponent>().componentState == ElectricalComponent.ComponentState.active)
        {
            //check if its off turn on else turn off ...
            if (switchState == SwitchState.off)
            {
                switchState = SwitchState.on;
                textStatusInfo.text = "ON";
            }
            else
            {
                switchState = SwitchState.off;
                textStatusInfo.text = "OFF";
            }
        }else
        {
            transform.position = GetComponent<ElectricalComponent>().activeTransform.position;
            transform.localRotation = GetComponent<ElectricalComponent>().activeTransform.localRotation;

            GetComponent<ElectricalComponent>().componentState = ElectricalComponent.ComponentState.active;
        }
        

        Debug.Log("Switch Status " + textStatusInfo.text);

        ElectricalCircuitBuildingModule.getInstance().changeWireColorBasedOnSwitch(switchState);
        

    }







}