using UnityEngine;

public class FollowingColor : MonoBehaviour
{
    private ColourChange ColorChanger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        
    }
}
