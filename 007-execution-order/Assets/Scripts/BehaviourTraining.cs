using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTraining : MonoBehaviour
{
    string objectName = "test";
    // Use this method before initialization
    private void Awake()
    {
        Debug.Log("This class is about to wake up");
    }
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("This class just started");
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
         transform.position = transform.position + Vector3.forward;
        if (Input.GetKeyDown(KeyCode.S))
            transform.position = transform.position + Vector3.back;
        if (Input.GetKeyDown(KeyCode.A))
            transform.position = transform.position + Vector3.left;
        if (Input.GetKeyDown(KeyCode.D))
            transform.position = transform.position + Vector3.right;

    }
}
