﻿//複数のプレイヤーをたくさん登場させて、それぞれのステータスを除いたり、特技を順番に披露させるプログラム

using object_study;
using System.Threading;

Player suzuki = new Player("鈴木"); //クラスの実体化 インスタンス化
//suzuki.Name("鈴木");
//suzuki.Action();
//suzuki.StatusDisplay();
//suzuki.SpecialAttack();

Player tanaka = new Warrior("");
//tanaka.NameSet("田中");
////tanaka.name = "田中";
//tanaka.Action(1);
//tanaka.StatusDisplay();
//tanaka.SpecialAttack();

Warrior yamada = new Warrior("山田");
//yamada.NameSet("山田");
//yamada.Action(2);
//yamada.HardAttack();
//yamada.StatusDisplay();
//yamada.SpecialAttack();


List<Player> players = new List<Player>();
players.Add(suzuki);
players.Add(tanaka);  
players.Add(yamada);

players.RemoveAt(1);

//配列に順番に処理する繰り返し構文　米リストも指定可能
//抽出する情報の型名　一時的に情報取り扱う返送

foreach (Player p in players)
{
    p.StatusDisplay();
    p.SpecialAttack();
}