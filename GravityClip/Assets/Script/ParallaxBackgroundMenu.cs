using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackgroundMenu : MonoBehaviour
{


    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    public Vector2 distance;
    private float textureUnitSizeX;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform =Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position-lastCameraPosition;
        transform.position+= new Vector3(deltaMovement.x*distance.x, deltaMovement.y*distance.y);
       lastCameraPosition= cameraTransform.position;

       if(Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitSizeX){

        transform.position = new Vector3(cameraTransform.position.x, transform.position.y);
    
       }
    }

}
