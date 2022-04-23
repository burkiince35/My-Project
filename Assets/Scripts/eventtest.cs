using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventtest : MonoBehaviour
{
    public delegate void delegatetest(); // bir tane delegate tan�mlad�m.
    public event delegatetest event1; // delegate e ba�vurarak bir tane event ol��turdum.
    public event delegatetest event2; // 2.event� olu�turdum.
    void Start()
    {
        event1 += Method1; // 1.evente 1.metod eklendi.
        event2 += Method2; // 2.evente 2.metod eklendi.
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // K ye bast���mda event1 �al���yor.
        {
            event1();
        }
        if (Input.GetKeyDown(KeyCode.L)) // L ye bast���mda event2 �al���yor.
        {
            event2();
        }
    }

    public void Method1()
    {
        Debug.Log("K ye bas�ld�"); // 1.method �al��t��� zaman bu olacak.
    }

    public void Method2()
    {
        Debug.Log("L ye bas�ld�"); // 2.metod �al��t��� zaman bu olcak.
    }
}
