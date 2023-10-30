using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour {
    public GameObject Player;
    public float Speed = 5;

    // Start is called before the first frame update
    void Start() {
        Player = GameObject.FindWithTag("Player");
        int spawMob = Random.Range(1, 28);
        transform.GetChild(spawMob).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void FixedUpdate() {
        Vector3 direction = transform.position - Player.transform.position;
        float dist = Vector3.Distance(transform.position, Player.transform.position);

        Quaternion rotation = Quaternion.LookRotation(-direction);
        GetComponent<Rigidbody>().MoveRotation(rotation);

        if (dist > 2.5) {
            GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position - direction.normalized * Speed * Time.deltaTime);
            GetComponent<Animator>().SetBool("Attack", false);
          
        }

        else {
            GetComponent<Animator>().SetBool("Attack", true);
        }
    }

    void AttackPlayer() {
        int damage = 30;
        
        Player.GetComponent<PlayerController>().takeHit(damage);
    }
}
