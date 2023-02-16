using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 




   [Range(0, 5)] public float speed = 1f;
        public SpriteRenderer sr;
    public Color ourColor; // Start is called before the first frame update
    public GameObject TextGameObject;
    public MessageScript textScript;
    void Start()
    {
        

     
      sr = GetComponent<SpriteRenderer>();
        
        sr.color = ourColor;


 
     }
 

    // Update is called once per frame
    void Update()
    {
    float xMove = Input.GetAxisRaw("Horizontal");
    this.transform.Translate(xMove * speed * Time.deltaTime, 0, 0);

    if (Input.GetKey(KeyCode.R))
    {
        sr.color = ourColor;
            textScript.ChangeText("I'm Angry");

    }
   
    else
    {
        sr.color = Color.white;
            textScript.ChangeText("Hello Everyone!");
    }
    }
}
