using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardPlayer : MonoBehaviour
{
    Transform player;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update() {
        if (player) {
            transform.position = Vector3.MoveTowards (
                transform.position, player.position, Time.deltaTime * speed
            );
        }
    }
}
