using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogicScript : MonoBehaviour
{
    public PlayerScript ps;
    
    
    
    // Start is called before the first frame update
    public void ScaleUp(GameObject go)
    {
        
        Vector3 scaleToAdd = new Vector3(0.2f,0.2f,0.2f);
        go.transform.localScale += scaleToAdd;
        
    }
    public void ScaleDown(GameObject go)
    {

        Vector3 scaleToAdd = new Vector3(0.2f, 0.2f, 0.2f);
        go.transform.localScale -= scaleToAdd;
        
    }

    
}
