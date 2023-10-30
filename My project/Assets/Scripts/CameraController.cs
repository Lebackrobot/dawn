using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    Vector3 CameraDist;

    // Start is called before the first frame update
    void Start() {
        CameraDist = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update() {
        transform.position = Player.transform.position + CameraDist;
    }
}