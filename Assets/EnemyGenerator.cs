using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public List<GameObject> enemy = new List<GameObject>();
    public GameObject prefabEnemy;
    public void Add()
    {
        GameObject goEnemy = Instantiate(prefabEnemy) as GameObject;
        this.enemy.Add(goEnemy);
        goEnemy.name = $"enemy_{enemy.Count}";
    }
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Add();
        }
    }
    private void Update()
    {
        if( this.gameObject == null)
        {

        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(enemy[1]);
            enemy.Remove(enemy[1]);
        }
    }

}
