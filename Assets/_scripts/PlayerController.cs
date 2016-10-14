using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{

  //Скорость перемеения персонажей
  public float _Speed;
  // получим ссылки на объекты в которых может находиться левый игрок
  public List<GameObject> SpawnLeft;
  // получим ссылки на объекты в которых может находиться правый игрок
  public List<GameObject> SpawnRigth;
  // ссылки на объек левого и правого игрока
  public Transform _leftPlayer;
  public Transform _rigthPlayer;

  //обозначим текущее положение игроков
 public bool _leftWay
  {
    get { return _leftPlayer; }
    set
    {
      targetLeft = value ? SpawnLeft[1].transform.position : SpawnLeft[0].transform.position;
    }
  }
 public bool _rigthWay
  {
    get { return _rigthWay; }
    set
    {
      targetRigth = value ? SpawnRigth[1].transform.position : SpawnRigth[0].transform.position;
    }
  }

  Vector3 targetLeft;
  Vector3 targetRigth;

  //Поставим 2-х персонажей на весто в середину экрана
  void SetStartPosotion()
  {
    _leftWay = true;
    _rigthWay = true;
  }
  
  void Update()
  {
    _leftPlayer.position = Vector3.Lerp(_leftPlayer.position, targetLeft, Time.deltaTime* _Speed);
    _rigthPlayer.position = Vector3.Lerp(_rigthPlayer.position, targetRigth, Time.deltaTime* _Speed);

  }

  void Start()
  {
    SetStartPosotion();
  }





}
