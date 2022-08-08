using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float vel = 0.5f;
    [SerializeField]
    private float variacaoY;
    private Vector3 posicaoAviao;
    private bool pontuei;
    private Pontuacao pontucao;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        this.posicaoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontucao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * this.vel * Time.deltaTime); 

        if(!this.pontuei && this.transform.position.x < this.posicaoAviao.x)
        {
            this.pontuei = true;
            this.pontucao.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
