using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 initialPos;
    bool hasLanded;
    bool Thrown;
    int DiceValue;
    [SerializeField]AnotherScript[]_ds;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
        initialPos = transform.position;
        _ds = GetComponentsInChildren<AnotherScript>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RollDice();
        }
    }

    void RollDice()
    {
        if (!Thrown && !hasLanded)
        {
            Thrown = true;
            rb.useGravity = true;
            rb.AddTorque(Random.Range(25, 100), Random.Range(25, 100), Random.Range(25, 100));
        }
        else if (Thrown && hasLanded)
        {
            
        }
    }
}
