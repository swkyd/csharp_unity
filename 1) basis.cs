using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  класс (class) - шаблон кода, по которому создаётся какой-то объект (как инструкция) */
    public class NewBehaviourScript : MonoBehaviour 

/*  модификатор доступа (access modifiers) - позволяет задать допустимую область видимости
    для компонентов класса

    [SerializeField]        
    private float speed = 25.6f;  // видно в unity, но невозможно менять данные

    private float speed = 25.6f;  // невидно в unity и невозможно менять данные
    public float speed = 25.6f;   // видно в unity и возможно менять данные             */

/*  переменная (variable) - хранилище данных. сюда можно положить какое-то значение

    string name = "Dior";         // для текста
    int age = 21;                 // для целое число
    float speed = 25.6f;          // для 7 цифр после запятое (точное)
    double height = 176.991;      // для 15 цифр после запятое (более точное)
    bool alive = true;            // для true или false

    GameObject ball;              // чтобы перетянуть объект в unity
    AudioSource audio;                                                                   */

{
/*  функция (function) - мини-программа внутри основной программы, которая
    делает какую-то одну понятную вещь

    void awake () {}              // работает после загрузки игры
    void Start () {}              // работает при старте игры
    void Update () {}             // работает при каждом фрейме
    void fixedUpdate () {}        // работает определенное количество раз при каждом фрейме

    кастомные функции - кастомные функции сами не вызываются, поэтому
    вызываем с помощью встроенных функции (awake, start, update, fixedupdate)

    private float speed = 25.6f; 

    void awake () {               // с помощью функции awake, вызываю
        swift (speed);                                  функцию swift
    }

    void swift () {
        print (speed);
    }                                                                                   */
                                                                                   
}