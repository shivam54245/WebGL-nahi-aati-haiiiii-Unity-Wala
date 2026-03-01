using UnityEngine;

public class ColourChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void SetColor(int color_code = 1)
    {
        if (color_code == 1)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (color_code == 2)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (color_code == 3)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    void Awake()
    {
        Debug.Log("ColorChange Script Awakened.");
    }
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SetColor(1);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            SetColor(2);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SetColor(3);
        }
        
    }
}
