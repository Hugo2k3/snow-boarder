using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustPaticles;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            dustPaticles.Play();
        }
    }
     void OnCollisionExit2D(Collision2D collision)
    {
        dustPaticles.Stop();
    }

}
