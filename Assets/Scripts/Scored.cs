using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Scored : MonoBehaviour
{
    [Tooltip("Pocet bodu, o ktery se zvysi skore.")]
    [SerializeField]
    private int points = 1;

    AudioSource audioSource;

    //public UnityEventInt PlayerScored;

    public UnityEvent<int> PlayerScored;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.PlayerScored?.Invoke(points);
        audioSource.time = 1;
        audioSource?.Play();
    }
}