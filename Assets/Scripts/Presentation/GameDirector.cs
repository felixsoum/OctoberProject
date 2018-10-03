using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterArena;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    ActorPanel[] actorPanels;

    void Start()
    {
        Monster[] monsters = new Monster[] {
        new Daniel("David"),
        new AtlasWorldLifter("Victor"),
        new Nana.Lich("Brad"),
        new HeroForFun("Youcef")
        };

        foreach (var monster in monsters)
        {
            monster.Spawn();
        }

        for (int i = 0; i < 4; i++)
        {
            actorPanels[i].name.text = monsters[i].GetData().name;
            actorPanels[i].hp.text = "hp " + monsters[i].GetData().hp;
        }


    }
}
