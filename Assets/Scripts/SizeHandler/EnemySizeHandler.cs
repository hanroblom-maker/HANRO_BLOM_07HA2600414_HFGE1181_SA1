using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemySizeHandler : UnitSizeHandler
{
    [Header("Feedback Settings")] 
    [SerializeField] protected Animator anim;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    protected override void Consume(GameObject unit)
    {
        if (unit.CompareTag("Player") && !isSmaller)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            Debug.Log("Enemy consumed: " + unit.name); //
            Debug.Log("Enemy size before: " + size); //
            Debug.Log("Enemy satiation before: " + satiationValue); //

            // anim.SetTrigger("Bite");
            base.Consume(unit);

            Debug.Log("Enemy satiation after: " + satiationValue); //
        }

    }

    private void OnDestroy()
    {
        SpawnManager.Instance.CleanEnemyArray(this);
    }
}
