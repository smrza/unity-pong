using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    Rigidbody2D rigidBody2D;

    [Tooltip("Minimal ball power.")]
    [SerializeField]
    Vector2 forceMin;

    [Tooltip("Maximal ball power.")]
    [SerializeField]
    Vector2 forceMax;

    [Tooltip("Force delay")]
    [SerializeField]
    float delay = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = this.GetComponent<Rigidbody2D>();

        StartCoroutine(nameof(Ball.PlayDelay));
    }

    /*public*/ IEnumerator PlayDelay()
    {
        yield return new WaitForSeconds(delay);

        float generovanySmer = Random.Range(0.0f, 1.0f);
        float forceX = Random.Range(forceMin.x, forceMax.x);
        float forceY = Random.Range(forceMin.y, forceMax.y);
        Vector2 force = new Vector2();

        if (generovanySmer <= 0.25)
        {
            force = new Vector2(forceX, forceY);
        }
        else if (generovanySmer <= 0.5)
        {
            force = new Vector2(forceX, -forceY);
        }
        else if (generovanySmer <= 0.75)
        {
            force = new Vector2(-forceX, forceY);
        }
        else //if(generovanySmer <= 1.0)
        {
            force = new Vector2(-forceX, -forceY);
        }

        rigidBody2D.AddForce(force, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
