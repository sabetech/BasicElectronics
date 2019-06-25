﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{   
    /*
        There are different types of interactable ... 
        - Table
        - Electrical Component like Battery, Bulb Etc
        - Wire?
        - Terminals are interactable
     */
     
     private Camera m_Camera = null;

    private void Awake(){
        m_Camera = Camera.main;
    }
    private void OnDestroy(){

    }

    private void Start() {
        
    }

    public void Pressed() {
        // Do action here ...   
        //find what was pressed actually ...

        GameObject objectPressed = this.gameObject;

        switch(objectPressed.tag){
            case "ElectricalComponent":
            
                ElectricalComponent electricComponent =  objectPressed.GetComponent<ElectricalComponent>();
                electricComponent.actionPerformedOnClick();
            
            break;
            
            case "Terminal":
                
                Terminal terminal = objectPressed.GetComponent<Terminal>();
                terminal.actionPerformedOnClick();
            
            break;

            case "Switch":
            
                LightSwitch lightSwitch = gameObject.GetComponent<LightSwitch>();
                lightSwitch.actionPerformedOnClick();

            break;

            case "ButtonInteraction":
                
                NextDemo nextDemo = objectPressed.GetComponent<NextDemo>();
                nextDemo.actionPerformedClick();

                break;
        }
        

    }   

    public void Hovered() {

        //determine what was hovered on ...

        //do something based on the object and the state of it
        GameObject objectPressed = this.gameObject;
        switch(objectPressed.tag){
            case "ElectricalComponent":
                
                ElectricalComponent electricComponent =  objectPressed.GetComponent<ElectricalComponent>();
                electricComponent.actionPerformedOnHover();
                
            break;
            
            case "Terminal":
                
                Terminal terminal = objectPressed.GetComponent<Terminal>();
                terminal.actionPerformedOnHover();
                
            break;
        }



    }

    public void HoveredOff() {

        //Debug.Log("game object off hover "+ this.gameObject.name);
        GameObject objectPressed = this.gameObject;
        switch(objectPressed.tag){
            case "ElectricalComponent":
                
                ElectricalComponent electricComponent =  objectPressed.GetComponent<ElectricalComponent>();
                electricComponent.actionPerformedOnHoverOff();
                
            break;
            
            case "Terminal":
                
                Terminal terminal = objectPressed.GetComponent<Terminal>();
                terminal.actionPerformedOnHoverOff();
                
            break;
        }

    }


}
