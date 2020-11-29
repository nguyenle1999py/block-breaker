using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    Level level;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.countBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position);
        Destroy(gameObject);
        level.deleteBlocks();
    }
}
