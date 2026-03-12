using UnityEngine;

public class Gravity : MonoBehaviour
{

    public GameObject targetObject;
    public float mass = 10f;
    public Vector2 velocity = new Vector2(0, 0);
    private float G = 6.626f;
    private Mass mass_self;


    void Start()
    {
        mass_self.value = mass;
    }


    // Update is called once per frame
    void Update()
    {
        float mass_targetObject_value = targetObject.GetComponent<Mass>().value;
        Vector2 distance = transform.position - transform.position;
        Vector2 acceleration = G * mass_targetObject_value * distance.normalized / (distance.magnitude * distance.magnitude);

        velocity += acceleration;
        transform.Translate(velocity * Time.deltaTime);

    }
}
