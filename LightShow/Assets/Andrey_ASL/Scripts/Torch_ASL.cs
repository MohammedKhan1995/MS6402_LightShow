using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Torch_ASL : MonoBehaviour

{
    public bool flashlightON;
    public GameObject Light;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            flashlightON = !flashlightON;
            
        if (flashlightON)
            Light.SetActive(true);
        else
            Light.SetActive(false);

       
    }
}
