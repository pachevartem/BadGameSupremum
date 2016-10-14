using UnityEngine;
using System.Collections.Generic;

public class EnemyController : MonoBehaviour {

  public GameObject MiddleLeftSpawnEnemy;
  public GameObject killMiddleLeftSpawnEnemy;


  public GameObject MiddleRigthSpawnEnemy;
  public GameObject killMiddleRigthSpawnEnemy;

  public GameObject LeftSpawnEnemy;
  public GameObject killLeftSpawnEnemy;


  public GameObject RigthSpawnEnemy;
  public GameObject killRigthSpawnEnemy;


  public GameObject _enemy;

  void Start()
  {
    _enemy = Instantiate(_enemy);
  }

  void Update()

  {
    _enemy.transform.position = Vector3.MoveTowards(_enemy.transform.position, killLeftSpawnEnemy.transform.position, Time.deltaTime * 2);
  }

}
