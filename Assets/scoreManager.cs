using UnityEngine;

public class scoreManager : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Target"))
        {
            Debug.Log("You scored");

            GameObject go = GameObject.Find("GameManager");
            GameManager gm = (GameManager)go.GetComponent(typeof(GameManager));
            gm.updateScore();
            Destroy(collision.collider.gameObject);
        }
    }

}
