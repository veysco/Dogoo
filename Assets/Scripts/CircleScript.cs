using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer SpriteRenderer;
    
    private void Start()
    {
        int greenOrRed = Random.Range(0, 2);
        if (greenOrRed == 1)
        {
            SpriteRenderer.color = Color.green;
            gameObject.tag = "greenCircle";
        }
        else
        {
            SpriteRenderer.color = Color.red;
            gameObject.tag = "redCircle";
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7)
        {
            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
 
}
