using UnityEngine;
using UnityEngine.UI;

public class Euro_Lotto : MonoBehaviour
{
    public Text LZ1;
    public Text LZ2;
    public Text LZ3;
    public Text LZ4;
    public Text LZ5;
    public Text EZ1;
    public Text EZ2;

    private int intLZ1;
    private int intLZ2;
    private int intLZ3;
    private int intLZ4;
    private int intLZ5;
    private int intEZ1;
    private int intEZ2;

    // "Start" wird aufgerufen, bevor eine der "Update"-Methoden erstmalig aufgerufen wird
    private void Start()
    {
        Reset();

        intEZ1 = Random.Range(1, 11);
        EZ1.text = intEZ1.ToString();

        intEZ2 = Random.Range(1, 11);
        EZ2.text = intEZ2.ToString();
    }

    private void Reset()
    {
        intLZ1 = Random.Range(1, 51);
        intLZ2 = Random.Range(1, 51);
        intLZ3 = Random.Range(1, 51);
        intLZ4 = Random.Range(1, 51);
        intLZ5 = Random.Range(1, 51);

        LZ1.text = intLZ1.ToString();
        LZ2.text = intLZ2.ToString();
        LZ3.text = intLZ3.ToString();
        LZ4.text = intLZ4.ToString();
        LZ5.text = intLZ5.ToString();
    }

    public void newL_btn_click()
    {
        Reset();
    }

    public void newS_btn_click()
    {
        intEZ1 = Random.Range(1, 11);
        EZ1.text = intEZ1.ToString();

        intEZ2 = Random.Range(1, 11);
        EZ2.text = intEZ2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //EZ1 && EZ2
        if (intEZ1 == intEZ2)
        {
            intEZ1 = Random.Range(1, 11);
            EZ1.text = intEZ1.ToString();

            intEZ2 = Random.Range(1, 11);
            EZ2.text = intEZ2.ToString();
        }

        //LZ5
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