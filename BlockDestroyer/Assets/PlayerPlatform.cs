using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour {
    [SerializeField]
    private float minPositionX;

    [SerializeField]
    private float maxPositionX;

    [SerializeField]
    private KeyCode KeyLeft = KeyCode.LeftArrow;

    [SerializeField]
    private KeyCode KeyRight = KeyCode.RightArrow;

    [SerializeField]
    private float Speed = 10;

    private void FixedUpdate() {
        if (Input.anyKey) {
            if (Input.GetKey(KeyLeft)|| Input.GetKey(KeyCode.A)) {
                transform.Translate(-Speed * Time.deltaTime, 0, 0);
                if (transform.position.x < minPositionX) {
                    transform.Translate(minPositionX - transform.position.x, 0, 0);
                }
            }
            if (Input.GetKey(KeyRight) || Input.GetKey(KeyCode.D)) {
                transform.Translate(Speed * Time.deltaTime, 0, 0);
                if (transform.position.x > maxPositionX) {
                    transform.Translate(maxPositionX - transform.position.x, 0, 0);
                }
            }
        }
    }
}