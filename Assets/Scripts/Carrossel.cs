using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private float vel;
    private Vector3 posicaoInicial;
    private float tamanhoRealImagem;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.tamanhoRealImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealImagem = tamanhoRealImagem * escala;
    }
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.vel * Time.time, this.tamanhoRealImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
