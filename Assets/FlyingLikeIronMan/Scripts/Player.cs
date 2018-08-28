using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour {

    public float maxVelocity = 10f;

    Rigidbody _rigidbody;

    
	void Start () {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
    private void FixedUpdate()
    {
        // Limit velocity:
        if (_rigidbody.velocity.magnitude > maxVelocity)
        {
            _rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, maxVelocity);
        }
    }

}
