using UnityEngine;

public class InteragirObjeto : MonoBehaviour 
{
    public float raioInteracao = 3f;
    public LayerMask camadaInterativa;

void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        VerificarObjetoProximo();
    }
}

void VerificarObjetoProximo()
{
    Collider[] objetos = Physics.OverlapSphere(pontoRaio.position, raioInteracao, camadaInterativa);

    foreach (Collider col in objetos)
    {
        Destroy(col.gameObject); // Destroi o objeto próximo
        Debug.Log("Objeto destruído: " + col.name);
    }
}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, raioInteracao);
    }
    public Transform pontoRaio;
}