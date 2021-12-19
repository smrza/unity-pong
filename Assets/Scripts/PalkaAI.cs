using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalkaAI : MonoBehaviour
{
    [SerializeField]
    GameObject target; //micek

    [SerializeField]
    Rigidbody2D rigidBody2D;

    [SerializeField]
    float speed;

    [SerializeField]
    bool useForce = false;

    float timeElapsed;
    [SerializeField]
    float delay = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    
    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            float rozdilPozic = target.transform.position.y - this.transform.position.y;
            if (rigidBody2D == null || useForce == false)
            {
                this.transform.Translate(0, speed * rozdilPozic * Time.deltaTime, 0);
            }
            else
            {
                if (timeElapsed >= delay)
                {
                    rigidBody2D.velocity = Vector2.zero;
                    timeElapsed = 0;
                    rigidBody2D.AddForce(new Vector2(0, speed * rozdilPozic * Time.deltaTime), ForceMode2D.Force);
                }
                else
                {
                    timeElapsed += Time.deltaTime;
                }
            }
        }
    }
    
    /*
    void Update()
    {
        if (target != null)
        {
            float generovanySmer = Random.Range(0.0f, 1.0f);
            if (generovanySmer <= 0.5)
            {
                float rozdilPozic = target.transform.position.y - this.transform.position.y;
                if (rigidBody2D == null || useForce == false)
                {
                    this.transform.Translate(0, speed * rozdilPozic * Time.deltaTime, 0);
                }
                else
                {
                    if (timeElapsed >= delay)
                    {
                        rigidBody2D.velocity = Vector2.zero;
                        timeElapsed = 0;
                        rigidBody2D.AddForce(new Vector2(0, speed * rozdilPozic * Time.deltaTime), ForceMode2D.Force);
                    }
                    else
                    {
                        timeElapsed += Time.deltaTime;
                    }
                }
            }
            else
            {
                //todo
            }
        }
    }
    */

}
