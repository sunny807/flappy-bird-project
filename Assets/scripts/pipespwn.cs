using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pipespwn : MonoBehaviour
{
    public GameObject pipe;
    public float spwanrate = 2;
    private float timer= 0;
   public float heightoffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        spwanpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spwanpipe();
            timer = 0;
        }
    }
    void spwanpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
