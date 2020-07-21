using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private int HP = 3;
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "ball") {
            HP--;
        }
    }
    void Update()
    {
        if (HP <= 0)
            Destroy(this.gameObject);
    }
}
