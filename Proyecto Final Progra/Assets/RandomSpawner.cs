using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public float tiempoEntreInstancias = 3f;
    public float radioSpawn = 5f;

    [Header("Debug")]
    public Vector3 spawnerpoint;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Instanciarobjetoaleatorio", 0f, tiempoEntreInstancias);
    }

    void Instanciarobjetoaleatorio()
    {
        Vector3 posicionaleatoria = Random.insideUnitCircle * radioSpawn;
        posicionaleatoria.z = 0f;

        GameObject Randomonj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject nuevoObjeto = Instantiate(Randomonj, spawnerpoint + posicionaleatoria, Quaternion.identity);

        SpriteRenderer spriterenderer = nuevoObjeto.GetComponent<SpriteRenderer>();
        if (spriterenderer != null)
        {
            spriterenderer.color = new Color(Random.value, Random.value, Random.value);
        }
        nuevoObjeto.transform.parent = transform;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(spawnerpoint, radioSpawn);
    }

}