using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public Animator animator;

    IEnumerator waiter() {
        animator.SetBool("started", true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Mainscreen");
        Debug.Log("Switched Scenes");
    }

    public void StartGame() {
        StartCoroutine(waiter());
    }
}
