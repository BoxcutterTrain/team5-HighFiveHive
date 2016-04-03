using UnityEngine;
using System.Collections;

public class space_ship_circle_moution : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
    public float angle = 0;
    public float speed = (2 * Mathf.PI) / 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
    public float radius = 50;
    // Update is called once per frame
    void Update () {
        angle += speed * Time.deltaTime; //if you want to switch direction, use -= instead of +=
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        this.transform.position = new Vector3(x, 50f, y);
        this.transform.Rotate(0, -30*speed * Time.deltaTime, 0, Space.World);
    }
}
