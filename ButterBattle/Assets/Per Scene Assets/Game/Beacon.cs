using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beacon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
    }
    public void OnTriggerStay(Collider other)
    {
        Debug.Log(other);
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision);
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
    }
}