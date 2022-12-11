using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        DestroyThrowable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
    IEnumerator ExecuteAfterTime(float time)
    {

        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    private void DestroyThrowable()
    {
            StartCoroutine(ExecuteAfterTime(3.5f));
    }
}
