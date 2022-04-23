using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventtest : MonoBehaviour
{
    public delegate void delegatetest(); // bir tane delegate tanýmladým.
    public event delegatetest event1; // delegate e baþvurarak bir tane event olýþturdum.
    public event delegatetest event2; // 2.eventý oluþturdum.
    void Start()
    {
        event1 += Method1; // 1.evente 1.metod eklendi.
        event2 += Method2; // 2.evente 2.metod eklendi.
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // K ye bastýðýmda event1 çalýþýyor.
        {
            event1();
        }
        if (Input.GetKeyDown(KeyCode.L)) // L ye bastýðýmda event2 çalýþýyor.
        {
            event2();
        }
    }

    public void Method1()
    {
        Debug.Log("K ye basýldý"); // 1.method çalýþtýðý zaman bu olacak.
    }

    public void Method2()
    {
        Debug.Log("L ye basýldý"); // 2.metod çalýþtýðý zaman bu olcak.
    }
}
