using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float power;
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        if(rb == null){
            rb = gameObject.AddComponent<Rigidbody>();
            rb.useGravity = false;
        }
    }

    public void Move(Vector3 vector){
        rb.AddForce(vector * power/10, ForceMode.Force);
    }

    public void Spin(Vector3 spin_vector){
        rb.AddTorque(spin_vector * power/10, ForceMode.Force);
    }

    public void SpinMouse(Vector3 spin_vector, float k){
        rb.AddTorque(spin_vector * power/10 * k, ForceMode.Force);
    }
}
