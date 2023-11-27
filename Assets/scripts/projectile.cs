using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;
    public AudioSource audioPlayer;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null) {
            if (hitInfo.collider.CompareTag("Enemy")) {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                audioPlayer.Play();
            }
            DestroyProjectile();
        }
        

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyProjectile() {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        transform.position = Vector3.one * 9999f; // move the game object off screen while it finishes it's sound, then destroy it
        Destroy(gameObject, 3);
    }

}
