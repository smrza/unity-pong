using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalkaController : MonoBehaviour
{
    [Tooltip("Move up")]
    [SerializeField]
    private KeyCode UpKey;
    [Tooltip("Move down")]
    [SerializeField]
    private KeyCode DownKey;
    [Tooltip("Movement force on axis Y")]
    [SerializeField]
    private float forceY = 10.0f;
    /*[Tooltip("Movement Speed on axis X")]
    [SerializeField]
    private float SpeedX = 0.0f;*/


    Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(UpKey) == true) 
        {
            //Vector3 zmenaPozice = new Vector3(0, SpeedY * Time.deltaTime);
            //this.transform.Translate(zmenaPozice);

            

            rigidBody2D.AddForce(new Vector2(0, SpeedY*100000000), ForceMode2D.Force);
        }

        if (Input.GetKey(DownKey) == true)
        {
            Vector3 zmenaPozice = new Vector3(0, -SpeedY * Time.deltaTime);
            this.transform.Translate(zmenaPozice);
        }

        if (Input.GetKeyUp(UpKey) == true)
        {
            //Vector3 zmenaPozice = new Vector3(0, SpeedY * Time.deltaTime);
            //this.transform.Translate(zmenaPozice);

           // rigidBody2D = this.GetComponent<Rigidbody2D>();

            //rigidBody2D.AddForce(new Vector2(0, -SpeedY*100000000), ForceMode2D.Force);
            rigidBody2D.velocity = Vector2.zero;
        }
        */



        if (Input.GetKeyDown(UpKey) == true)
        {
            rigidBody2D.AddForce(new Vector2(0, forceY /** Time.deltaTime*/), ForceMode2D.Force);
        }

        if (Input.GetKeyUp(UpKey) == true)
        {
            rigidBody2D.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(DownKey) == true)
        {
            rigidBody2D.AddForce(new Vector2(0, -forceY /** Time.deltaTime*/), ForceMode2D.Force);
        }

        if (Input.GetKeyUp(DownKey) == true)
        {
            rigidBody2D.velocity = Vector2.zero;
        }




    }
}
