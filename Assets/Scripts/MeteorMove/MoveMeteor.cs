using UnityEngine;

public class MoveMeteor : MonoBehaviour
{
    public float moveMeteor;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveMeteor * Time.deltaTime;
    }
}
