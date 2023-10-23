using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float Speed = 5;
    Vector3 direction;
    public LayerMask floorMask;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        transform.Translate(direction * Speed * Time.deltaTime);
        direction = new Vector3(horizontalAxis, 0, verticalAxis);
        GetComponent<Animator>().SetBool("Running", true);

        if (direction == Vector3.zero) {
            GetComponent<Animator>().SetBool("Running", false);
        }
    }

        void FixedUpdate() {
            GetComponent<Rigidbody>().MovePosition (
                GetComponent<Rigidbody>().position + (direction * Speed * Time.deltaTime)
            );

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
            RaycastHit impact;

            if (Physics.Raycast(ray, out impact, 100)) {
                Vector3 playerPosition = impact.point - transform.position;
                playerPosition.y = transform.position.y;

                Quaternion newRotation = Quaternion.LookRotation(playerPosition);
                GetComponent<Rigidbody>().MoveRotation(newRotation);
            }

        }
}
