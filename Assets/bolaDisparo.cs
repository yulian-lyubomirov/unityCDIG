using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class bolaDisparo : MonoBehaviour
{
    private float fuerzaDisparo=20f;
    private bool disparado=false;
    // Start is called before the first frame update

    void Start(){
        GetComponent<Rigidbody>().useGravity=false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){ //Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began para movil creo
            GetComponent<Rigidbody>().useGravity=true;
            GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaDisparo, ForceMode.Impulse);

        }
    
    }
}
