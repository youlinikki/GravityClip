using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamMouvement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
          transform.Translate(Vector3.right * Time.deltaTime);

    }
}
