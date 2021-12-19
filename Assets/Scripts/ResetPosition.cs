using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [Tooltip("Pozice, na kterou se po kolizi presune objekt, který koliduje s tímto objektem")]
    [SerializeField]
    Vector2 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = resetPosition;
        //add play delay!!! public IEnumerator PlayDelay() az se resetuje mícek a zmení smer a je tam prodleva
    }
}
