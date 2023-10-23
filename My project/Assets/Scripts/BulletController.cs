using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float Speed = 20;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()  {
        
    }

    void FixedUpdate() {
        GetComponent<Rigidbody>().MovePosition
        (GetComponent<Rigidbody>().position + transform.forward * Speed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider colliderObject) {

        if (colliderObject.tag == "Inimigo") {
            Destroy (colliderObject.gameObject);
        }

        Destroy(gameObject);
    }
}
