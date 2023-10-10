using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public float timeMax;
    private float time;
    //public float x;
    //public float y;

    public GameObject MeteorPrefab;
    GameObject Meteor;

    private void Start()
    {
        time = 1;
    }

    private void Update()
    {
        if(time > timeMax)
        {
            Meteor = Instantiate(MeteorPrefab);
            Meteor.transform.position = transform.position + new Vector3(Random.Range(-1.71f, 1.62f), 4.6f, 0);
            time = 0;
        }
        time += Time.deltaTime;
        Destroy(Meteor, 8f);
    }

}
