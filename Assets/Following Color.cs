using UnityEngine;

public class FollowingColor : MonoBehaviour
{
    private ColourChange ColorChanger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        ColorChanger = GameObject.Find("Square").GetComponent<ColourChange>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ColorChanger.SetColor(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ColorChanger.SetColor(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ColorChanger.SetColor(3);
        }
        
    }
}
