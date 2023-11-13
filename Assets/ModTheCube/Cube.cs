using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float horizontalAxis;
    public float verticalAxis;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        transform.Rotate(10.0f * Time.deltaTime, 1.0f, 5.0f);
      //  transform.position = new Vector3(0, 0, 0);

        transform.Translate(Vector3.up * Time.deltaTime* verticalAxis * 10.0f);
        transform.Translate(Vector3.left * Time.deltaTime* horizontalAxis * 10.0f);

        
    }
}
