

float attackPower = 10; //攻撃力10

Console.WriteLine("現在の攻撃力" + attackPower);

//インクリメント演算子
attackPower++; //1個増やす
//++attackPower; あり

Console.WriteLine("インクリメントの攻撃力" + attackPower);

//デクリメント演算子
attackPower--; //1個へらす
//--attackPower; あり

Console.WriteLine("デクリメントの攻撃力" + attackPower);


//攻撃の係数
float[] attack_k = { 3.3f, 4.4f, 5.5f, 6.6f, 7.7f };

Random rand = new Random();
int result;



for (int i = 0; i< 10;  i++)
{
   result = rand.Next(0, 5);
    Console.WriteLine("プレイヤーの攻撃" + attackPower * attack_k [result]);
 }

//おみくじの結果
string[] omikuzi = { "大吉","吉","末吉","凶" };


//result= rand.Next(0, 4);

//Console.WriteLine("おみくじ結果" + omikuzi[result]);

//while (result != 0) //条件の間繰り返す
//{
//    result = rand .Next(0, 4);
//}

//    Console.WriteLine("今年はついてるなぁ");


do
{
    result = rand.Next(0, 4);
    Console.WriteLine("おみくじ結果 :" + omikuzi[result]);
}
while (result != 0);
Console.WriteLine("今年はついてるなぁ");


//for(int i = 0; i< 4; i++)
//    [
//    Console.WriteLine(omikuzi[i]);
//]

//配列に順次処理に特価した繰り返し構文

foreach(string omi in omikuzi)
{
    Console.WriteLine(omi);
}