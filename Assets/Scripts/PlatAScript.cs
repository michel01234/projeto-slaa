using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlatAScript : MonoBehaviour
{
    [SerializeField] GameObject alvo;
    [SerializeField] GameObject posA;
    [SerializeField] GameObject posB;
    [SerializeField] private float vel;


    private void Start()
    {
        alvo = posA;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, alvo.transform.position, vel * Time.deltaTime);

        if (Vector2.Distance(transform.position, alvo.transform.position) < 0.1 && alvo == posA)
        {
            alvo = posB;
        }

        if (Vector2.Distance(transform.position, alvo.transform.position) < 0.1 && alvo == posB)
        {
            alvo = posA;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
