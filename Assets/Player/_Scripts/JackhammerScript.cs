using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class JackhammerScript : MonoBehaviour
{
    public Tilemap terrain;
    public ParticleSystem sparksEffect;
    new public Rigidbody2D rigidbody;
    public float bounceForce = 50;
    public float jumpForce = 150;

    public float jumping = 0f;
    public float hammerDelay = 0.5f;

    public bool shouldJump = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!shouldJump) return;
        if (sparksEffect) sparksEffect.Play();

        rigidbody.AddForce (
            transform.up * (jumping > 0f ? jumping * jumpForce : bounceForce),
            ForceMode2D.Impulse
        );

        var _i = Random.Range(0, collision.contactCount);

        var tileCoord = terrain.WorldToCell(collision.contacts[_i].point - collision.contacts[_i].normal * 0.1f);
        if (terrain.GetTile(tileCoord)){
            terrain.SetTile(tileCoord, null);
        }

        shouldJump = false;
    }

    private void OnCollisionStay2D(Collision2D collision) {
        OnCollisionEnter2D(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        shouldJump = true;
    }

    public void Start() {
        StartCoroutine("HammerTime");
    }

    IEnumerator HammerTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(hammerDelay);
            shouldJump = true;
        }
    }
}
