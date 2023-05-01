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
    for (int y = 1; y < 21; y++) {
        if(y%2==1){
            offset=0;
            
            for (int x = 0; x < 6; x++) {
                GameObject ladrillo1 = Instantiate(ladrillo, new Vector3(offset,y,-0.5f)+posicionTorre, Quaternion.identity);
                Renderer brickRenderer = ladrillo1.GetComponent<Renderer>();
                if (brickRenderer != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer.material.color = randomColor;
                }
                ladrillo1 = Instantiate(ladrillo, new Vector3(offset,y,10.5f)+posicionTorre, Quaternion.identity);
                Renderer brickRenderer2 = ladrillo1.GetComponent<Renderer>();
               if (brickRenderer2 != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer2.material.color = randomColor;
                }
                offset=offset+2;
            }
            offset=1;
          
            for (int x=0;x<5; x++){
                GameObject ladrillo1 = Instantiate(ladrillo, new Vector3(-0.5f,y,offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                Renderer brickRenderer = ladrillo1.GetComponent<Renderer>();
                if (brickRenderer != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer.material.color = randomColor;
                }
                ladrillo1= Instantiate(ladrillo, new Vector3(10.5f,y,offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                Renderer brickRenderer2 = ladrillo1.GetComponent<Renderer>();
              if (brickRenderer2 != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer2.material.color = randomColor;
                }
                offset=offset+2;
            }
        }
        else{
            offset=1;
            
            for (int x = 0; x < 5; x++) {
               GameObject ladrillo1=  Instantiate(ladrillo, new Vector3(offset,y,-0.5f)+posicionTorre, Quaternion.identity);
               Renderer brickRenderer = ladrillo1.GetComponent<Renderer>();
                if (brickRenderer != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer.material.color = randomColor;
                }
                ladrillo1= Instantiate(ladrillo, new Vector3(offset,y,10.5f)+posicionTorre, Quaternion.identity);
                Renderer brickRenderer2 = ladrillo1.GetComponent<Renderer>();
              if (brickRenderer2 != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer2.material.color = randomColor;
                }
                offset=offset+2;

            }
            offset=0;
            
            for (int x=0;x<6; x++){
                GameObject ladrillo1 = Instantiate(ladrillo, new Vector3(-0.5f,y,offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                Renderer brickRenderer = ladrillo1.GetComponent<Renderer>();
                if (brickRenderer != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer.material.color = randomColor;
                }
                ladrillo1= Instantiate(ladrillo, new Vector3(10.5f,y,offset)+posicionTorre,Quaternion.Euler(0f, 90f, 0f));
                Renderer brickRenderer2 = ladrillo1.GetComponent<Renderer>();
              if (brickRenderer2 != null)
                {
                    // Choose a random color from the list and set the brick's material to that color
                    Color randomColor = colorList[Random.Range(0, colorList.Count)];
                    brickRenderer2.material.color = randomColor;
                }
                 offset=offset+2;
            }
        }
        
        }
 }
    
        

        
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
