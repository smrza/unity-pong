using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [Tooltip("Pozice, na kterou se po kolizi presune objekt, kter� koliduje s t�mto objektem")]
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
        //add play delay!!! public IEnumerator PlayDelay() az se resetuje m�cek a zmen� smer a je tam prodleva
    }
}
