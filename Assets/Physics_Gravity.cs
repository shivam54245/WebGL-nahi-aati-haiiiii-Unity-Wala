using UnityEngine;

public class Gravity : MonoBehaviour
{

    public GameObject targetObject;
    public float mass = 10f;
    public Vector2 velocity = new Vector2(0, 0);
    private float G = 6.626f;
    private Mass mass_self;


    void Awake()
    {
        mass_self = gameObject.AddComponent<Mass>();
        mass_self.value = mass;
        Debug.Log("Mass of self: " + mass_self.value);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float mass_targetObject_value = targetObject.GetComponent<Mass>().value;
        Vector2 distance = targetObject.transform.position - transform.position;
        Vector2 acceleration = G * mass_targetObject_value * distance.normalized / distance.sqrMagnitude;

        velocity += acceleration*Time.deltaTime;
        transform.Translate(velocity * Time.deltaTime);

    }
}
