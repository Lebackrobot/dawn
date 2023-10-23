using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
    public GameObject Bullet;
    public GameObject Weapon;


    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetButtonDown("Fire1")) {
            Instantiate(Bullet, Weapon.transform.position, Weapon.transform.rotation);
        }
    }
}
