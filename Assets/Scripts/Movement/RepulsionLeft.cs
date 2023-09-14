using UnityEngine;

public class RepulsionLeft : MonoBehaviour
{
    [Header("сила отталкивания")]
    [Space]
    [SerializeField] private float _force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.rigidbody.AddForce(Vector2.right * _force, ForceMode2D.Impulse);
        }
    }
}
