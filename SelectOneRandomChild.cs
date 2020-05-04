using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOneRandomChild : MonoBehaviour
{
    //Attach this script to a game object that contains any number of children 
    //All children must be active, this script will disable all children, except for one random child
    void Start()
    {   
        int randomNumber = Random.Range(0,transform.childCount);
        Debug.Log("number of children: " + transform.childCount + " - random: " + randomNumber);

        int children = transform.childCount;
        for (int i = 0; i < children; ++i) {
            if( i != randomNumber ) {
                //print("For loop2: " + transform.GetChild(i).transform.parent.gameObject);
                print( "For loop2: " + transform.GetChild(i).transform.gameObject );
                transform.GetChild(i).transform.gameObject.SetActive(false);
                
            }
        }





    }

}
