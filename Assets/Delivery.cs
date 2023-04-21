using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackagecolor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackagecolor = new Color32(1,1,1,1);
    [SerializeField]float delay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(("ouch!!"));
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Package" && !hasPackage){
            Debug.Log(("Package picked up"));
            Destroy(other.gameObject,delay);
            hasPackage = true;
            spriteRenderer.color = hasPackagecolor;
        }

        else if(other.tag == "Customer" && hasPackage){
            Debug.Log(("Package delivered"));
            hasPackage = false;
            spriteRenderer.color = noPackagecolor;
        }
    }
    
}
