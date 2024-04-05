using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rig;
    [SerializeField] float forcaPulo;
    [SerializeField] float velMove;
    bool pdPula;
    [SerializeField] float move;

    private void Update()
    {
        move = Input.GetAxis("Horizontal");

        rig.velocity = new Vector2(move * velMove, rig.velocity.y);
            

        if (Input.GetAxis("Vertical") > 0 && Input.GetButtonDown("Vertical") && pdPula)
        {
            rig.AddForce(new Vector2 (rig.velocity.x, forcaPulo), ForceMode2D.Impulse);
            pdPula = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao")
        {
            pdPula = true;
        }
    }
}
