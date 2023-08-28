using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Farmer")
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        else
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;

    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
