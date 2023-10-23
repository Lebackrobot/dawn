using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject Mob;
    float Timer = 1;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        Timer += Time.deltaTime;

        if (Timer >= 1) {
            Instantiate(Mob, transform.position, transform.rotation);
            Timer = 0;
        }
    }
}
