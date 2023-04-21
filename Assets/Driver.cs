using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 100f;
    [SerializeField]float moveSpeed = 10f;
    [SerializeField]float slowSpeed = 8f;
    [SerializeField]float boostSpeed = 25f;

 
    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
     }

    
 
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; 
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Boost"){
            Debug.Log("you are boosting man!!");
            moveSpeed = boostSpeed;
        }
     }
    
}
