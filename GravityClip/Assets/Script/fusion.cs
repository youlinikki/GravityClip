using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusion : MonoBehaviour
{

    public GameObject position1;
    public GameObject position2;
    RaycastHit2D hit;
    public LayerMask layer;

    public int etat;

    
    
    // Start is called before the first frame update
    void Start()
    {
        DeplacementPersonnage cs = position1.GetComponent<DeplacementPersonnage>();
        bool saute = cs.vaADroite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C)&&etat<3)
        {
         etat =1;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
           if (!Physics2D.Linecast(position1.transform.position, position2.transform.position, layer)){
                position1.SetActive(false);
                etat =3;
            }
            }else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
           if (!Physics2D.Linecast(position1.transform.position, position2.transform.position, layer)){
                position2.SetActive(false);
                etat =5;
            }
            }
        }else{
            if(etat<3){etat =0;}
            
        }
        if (Input.GetKeyUp(KeyCode.C)&&etat==3){
            etat =4;
        }else if (Input.GetKeyUp(KeyCode.C)&&etat==5){
            etat =6;
        }

        if (Input.GetKey(KeyCode.C)&&etat==4){
            etat = 0;
            position1.SetActive(true);
            position1.transform.position =position2.transform.position;
        }else if (Input.GetKey(KeyCode.C)&&etat==6){
            etat = 0;
            position2.SetActive(true);
            position2.transform.position =position1.transform.position;
        }
        
        
         Debug.Log(etat);
    }
}
