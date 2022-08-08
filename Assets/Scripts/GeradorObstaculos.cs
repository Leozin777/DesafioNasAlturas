using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoGerar;
    [SerializeField]
    private GameObject manual;
    private float cronometro;

    private void Awake()
    {
        this.cronometro = this.tempoGerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;

        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.manual, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoGerar;
        }
    }
}
