using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lotto_tech : MonoBehaviour
{
    public Text LZ1;
    public Text LZ2;
    public Text LZ3;
    public Text LZ4;
    public Text LZ5;
    public Text LZ6;
    public Text SZ1;

    private int intLZ1;
    private int intLZ2;
    private int intLZ3;
    private int intLZ4;
    private int intLZ5;
    private int intLZ6;
    private int intSZ1;

    // "Start" wird aufgerufen, bevor eine der "Update"-Methoden erstmalig aufgerufen wird
    private void Start()
    {
        Reset();

        intSZ1 = Random.Range(1, 10);
        SZ1.text = intSZ1.ToString();
    }

    private void Reset()
    {
        intLZ1 = Random.Range(1, 50);
        intLZ2 = Random.Range(1, 50);
        intLZ3 = Random.Range(1, 50);
        intLZ4 = Random.Range(1, 50);
        intLZ5 = Random.Range(1, 50);
        intLZ6 = Random.Range(1, 50);

        LZ1.text = intLZ1.ToString();
        LZ2.text = intLZ2.ToString();
        LZ3.text = intLZ3.ToString();
        LZ4.text = intLZ4.ToString();
        LZ5.text = intLZ5.ToString();
        LZ6.text = intLZ6.ToString();
    }

    public void newL_btn_click() 
    {
        Reset();
    }

    public void newS_btn_click()
    {
        intSZ1 = Random.Range(1, 10);
        SZ1.text = intSZ1.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //LZ6
        if (intLZ6 == intLZ5)
        {
            Reset();
        }
        if (intLZ6 == intLZ4)
        {
            Reset();
        }
        if (intLZ6 == intLZ3)
        {
            Reset();
        }
        if (intLZ6 == intLZ2)
        {
            Reset();
        }
        if (intLZ6 == intLZ1)
        {
            Reset();
        }

        //LZ5
        if (intLZ5 == intLZ6)
        {
            Reset();
        }
        if (intLZ5 == intLZ4)
        {
            Reset();
        }
        if (intLZ5 == intLZ3)
        {
            Reset();
        }
        if (intLZ5 == intLZ2)
        {
            Reset();
        }
        if (intLZ5 == intLZ1)
        {
            Reset();
        }

        //LZ4
        if (intLZ4 == intLZ6)
        {
            Reset();
        }
        if (intLZ4 == intLZ5)
        {
            Reset();
        }
        if (intLZ4 == intLZ3)
        {
            Reset();
        }
        if (intLZ4 == intLZ2)
        {
            Reset();
        }
        if (intLZ4 == intLZ1)
        {
            Reset();
        }

        //LZ3
        if (intLZ3 == intLZ6)
        {
            Reset();
        }
        if (intLZ3 == intLZ5)
        {
            Reset();
        }
        if (intLZ3 == intLZ4)
        {
            Reset();
        }
        if (intLZ3 == intLZ2)
        {
            Reset();
        }
        if (intLZ3 == intLZ1)
        {
            Reset();
        }

        //LZ2
        if (intLZ2 == intLZ6)
        {
            Reset();
        }
        if (intLZ2 == intLZ5)
        {
            Reset();
        }
        if (intLZ2 == intLZ4)
        {
            Reset();
        }
        if (intLZ2 == intLZ3)
        {
            Reset();
        }
        if (intLZ2 == intLZ1)
        {
            Reset();
        }

        //LZ1
        if (intLZ1 == intLZ6)
        {
            Reset();
        }
        if (intLZ1 == intLZ5)
        {
            Reset();
        }
        if (intLZ1 == intLZ4)
        {
            Reset();
        }
        if (intLZ1 == intLZ3)
        {
            Reset();
        }
        if (intLZ1 == intLZ2)
        {
            Reset();
        }
    }
}
