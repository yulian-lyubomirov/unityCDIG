using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torreCuadrada : MonoBehaviour
{
    public GameObject ladrillo;
    private int offset;
    private Quaternion rotationQuaternion;
    void Start()
    {
        List<Color> colorList = new List<Color>();
        colorList.Add(Color.red);
        colorList.Add(Color.green);
        colorList.Add(Color.blue);
        colorList.Add(Color.yellow);
        colorList.Add(Color.magenta);
     Vector3 posicionTorre = GetComponent<Rigidbody>().transform.position;
     for (int y = 0; y < 21; y++) {
        if(y%2==0){
            offset=0;
            for (int x = 0; x < 6; x++) {
                GameObject ladrillo1 = Instantiate(ladrillo, new Vector3(x+offset,y,0)+posicionTorre, Quaternion.identity);
                Renderer brickRenderer = ladrillo1.GetComponent<Renderer>();
                if (brickRenderer != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer.material.color = randomColor;
                }
                Instantiate(ladrillo, new Vector3(x+offset,y,12)+posicionTorre, Quaternion.identity);
                offset=offset+1;
            }
            offset=1;
            for (int x=0;x<5; x++){
                Instantiate(ladrillo, new Vector3(0,y,x+offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                Instantiate(ladrillo, new Vector3(12,y,x+offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                offset=offset+1;
            }
        }
        else{
            offset=1;
            for (int x = 0; x < 5; x++) {
                Instantiate(ladrillo, new Vector3(x+offset,y,0)+posicionTorre, Quaternion.identity);
                Instantiate(ladrillo, new Vector3(x+offset,y,12)+posicionTorre, Quaternion.identity);
                offset=offset+1;
            }
            offset=0;
            for (int x=0;x<6; x++){
                Instantiate(ladrillo, new Vector3(0,y,x+offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                Instantiate(ladrillo, new Vector3(12,y,x+offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                 offset=offset+1;
            }
        }
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
