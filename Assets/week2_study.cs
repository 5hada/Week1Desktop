using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//�޼ҵ��� ��
public class Calculator
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
    
}


/*�޼ҵ��� ����
 *������ �ڵ� �ݺ� �ۼ� �ʿ� x 

private void Awake()
{
    //�޼ҵ��� �̸��� �ҷ� ���
    Multiple(3, 4);
    Multiple(5, 6);
    Multiple(7, 8);
}

//num1�� num2�� ���� �����ϴ� �޼ҵ� ����
public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
*/




/*�޼ҵ��� ��ȯ
 * return�� ȣ���� �޼ҵ带 �����ϰ� ���ο��� ��ȯ�� �����͸� ��ȯ 
private void Awake()
{
    int a = Max(10, 20);   //��ȯ�� �����͸� ������ ����
    Debug.Log(Max(100, 200));  //������ ���� ���� ��ȯ�� �����͸� �ٷ� ��� ����
    Max(50, 100);    //��ȯ�� �����͸� �� ���� �ʾƵ� ��
}

public int Max(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

public void Divide(int num1, int num2)
{
    if (num2 == 0)
    {
        Debug.Log("�������� ���� 0�̱� ������ ���α׷� ����");
        return;   //�޼ҵ� ����
    }
    float result = num1 / num2;
    Debug.Log($"{num1} / {num2} = {result}");
}
*/




/*�Ű�����
 *�޼ҵ� ���ο��� ���Ǵ� ��������
 *�޼ҵ� �ܺο��� ���η� ������ ���� 
 *�޼ҵ��� Ȱ�뼺 ����

public void Awake()
{
    int a = 3 ,b = 4;
    Add(a, b);   //�޼ҵ� ȣ�� �� �Ű������� a, b ����
}

public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
*/




/*���� ��
private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"a={a}, b = {b}");
    Swap(ref a, ref b);
    Debug.Log($"a={a}, b = {b}");
}

pubilc void Swap(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
Debug.Log($"num1={num1}, num2 = {num2}");
}
*/



/* //��� ���� �Ű� ���� ref
 * 2�� �̻��� ����� ��ȯ  
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, ref result1, ref result2);
    Debug.Log($"�� = {result}, ������ = {result2}")
}

public void Divide(int num1, int num2, ref int result1, ref int result2)
{
    result1 = num1 / num2;
    result2 = num1 % num2;
}
*/

/* //��� ���� �Ű� ���� out(����)  
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, out result1, out result2);
    Debug.Log($"�� = {result}, ������ = {result2}")
}

public void Divide(int num1, int num2, out int result1, out int result2)
{
    result1 = num1 / num2;
    result2 = num1 % num2;
}
*/



/* //�޼ҵ� �����ε� 
 * ������ �޼ҵ� �̸����� ���� �޼ҵ� ���� 
public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

public void Add(float num1, float num2)
{
    float result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
*/




/* //�������� �Ű����� params
 * ������ ���̰� �ٸ� �޼ҵ尡 ���� �ʿ��� ���(������ ���ƾ� ��) 

public class week2_study_method : MonoBehaviour
{
    public void Sum(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        Debug.Log($"�հ� = {sum}");
    }
    void Start()
    {
        Sum(1, 2, 3, 4, 5);
        Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
    }
}
*/


/* //���� �Ű����� 
 * ���� ��� ���� ���� �̸��� �ٰ��� ������ �Ҵ� */
public class week2_study : MonoBehaviour
{
    public void Player(string ID, int health)
    {
        Debug.Log($"ID = {ID}, HP = {health}");
    }
    void Start()
    {
        Player("�̸�", 100);  //�Ϲ����� �Ű� ����
        Player(ID: "�̸�", health: 100);  //���� �Ű� ����
        Player(health: 100, ID: "�̸�");  //���� �ٲ� �۵�
    }
}


/* //������ �Ű�����
 * �Ű������� �⺻�� ���� ����
 * �׻� �ʼ� �Ű����� �ڿ� �;� �� 
public class week2_study : MonoBehaviour
{
    public void Player(string ID, int health = 1000)
    {
        Debug.Log($"ID = {ID}, HP = {health}");
    }
    void Start()
    {
        Player("�̸�");  //�⺻�� ���
        Player("�̸�", 3000);  //�⺻�� 
    }
}
*/





/* //Ŭ������ ��
public class Player : MonoBehaviour
{
    private string ID = "�̸�";
    private int currentHP = 1000;//��� ����

    public void TakeDamage(int damage) //��� �Լ�(�޼ҵ�)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
*/


/* //���� �������� �� 
public class Player : MonoBehaviour
{
    public string ID = "�̸�";  //�ܺο����� ���� ����
    private int currentHP = 1000;  //Ŭ���� ���ο����� ���� ����


    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
*/


/* //Ŭ������ �̿� 
public class Player
{
    public string ID = "�̸�";
    private int currentHP = 1000;

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
public class Enemy
{ 
    private Player = player;

    private void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}
*/


/* //Ŭ���� ��ü ���� 
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200); //���� �߻�
    }
}
*/
/* //������ 
public class Player
{
    public string ID;
    public int currentHP;

    public Player()
    {
        ID = "�̸�";
        currentHP = 1000;
    }
}
public class GameController : MonoBehaviour
{
    public Player player01;

    private void Awake()
    {
        player01 = new Player();//new�� ������ ȣ��
    }
}
*/
/* //������ �����ε�
public class Player
{
  public string ID;
    public int currentHP;

    public Player()
    {
        ID = "�̸�";
        currentHP = 1000;
    }
    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("����Ƽ", 10);
    }
}
*/
/* //�Ҹ���
public class Player
{
    public string ID;
    public int health;

    ~Player()
    {
        //c#������ �Ҹ��ڸ� ��� x
    }
}
*/



/* //���� ����
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("�̸�", 1000);
        player02 = player01; //���� ����
        player02.ID = "����Ƽ";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");//�� �� ����Ƽ ���
    }
}
*/
/* //���� ����
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("�̸�", 1000);

        player02 = player01.DeepCopy;
        player02.ID = "����Ƽ";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");//�̸�, ����Ƽ ���
    }
}

public class Player
{
    public string ID;
    public int currentHP;


    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}
*/

/* //this Ű����
 * Ŭ���� ���ο��� �ڱ� �ڽ��� ������ �޼ҵ忡 ������ �� ���
public class Player
{
    public string ID = "�̸�"; //Ŭ���� ��� ����

    public SetID(string ID) //��������
    {
        Debug.Log($"ID : {ID}"); //���������� ��Ī
        Debug.Log($"ID : {this.ID}"); //Ŭ���� ��� ������ ��Ī
    }
}
public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player() // 1) ������
    {
        ID = "�̸�";
    }
    public Player(int hp): this() // 1) this()�� �ٸ� ������ ȣ��, 2) ������
    {
        currentHP = hp;
    }
    public Player(int hp, int mp): this(hp) // 2) this(hp)�� �ٸ� ������ ȣ��
    {
        currentMP = mp;
    }
}
*/






/* //���� ���а� ĸ��ȭ ��
 * �Ϲ������� ������ �� Set, Get�ٿ� �޼ҵ� ������
public class Player
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        player.CurrentHP = 100; // private ��� ���� ���� �Ұ�
        Debug.Log($"HP : Player.currentHP");

        player.SetCurrentHP(100);
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
}
*/

/* //����� ��
public class Entity //��� Ŭ����
{
    public string ID;
    public int currentHP;

    public void Initialize();
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}
public class Player : Entity //�Ļ� Ŭ����
{
    public Player(string id, int hp)
    {
        ID - id;
        currentHP = hp;
        RecoveryHP(100);


        Initialize(); //private�̹Ƿ� ���� �Ұ�
    }
}
*/

/* //base Ű����
 * ��� Ŭ������ ����, �޼ҵ� ����
public class Entity
{
    public sring ID;        //��� Ŭ������ ID
    protected int currentHP;
}
public class Player : Entity
{
    private string ID;      //�Ļ� Ŭ������ ID

    public Player(string id, int hp)
    {
        base.ID = "Noname"; //��� Ŭ������ ID�� ����
        ID = id;            //�Ļ� Ŭ������ ID�� ����
        currentHP = hp;
    }

/* // ���� ���� ���İ� �޸� �Ҵ� ���Ŀ� ���� ��� ���� ���
public class Entity
{
    public void Attack;
    {
        Debug.Log("���� �����Ѵ�.");
    }
    public void Heal()
    {
        Debug.Log("ü���� ȸ���Ѵ�.");
    }
}
public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("��������!!");
    }
    public void Heal();
    {
        Debug.Log("����� ü�� ȸ��!");
    }
}
//��� ���� ���
private Entitiy entity = new Entity();
{
    Attack();
    Heal();
}
private Goblin goblin = new Goblin();
{
    Attack();
    Avoid();
    Heal(); //Goblin�� Heal() ȣ��
}
private Entity entity = new Goblin();
{
    Attack();
    Heal(); //Entity�� Heal() ȣ��
}
*/



/* //������2(�޼ҵ� �������̵�)
public class Entity
{
    public virtual void Attack()
    {
        Debug.Log("���� �����Ѵ�.");
    }
}
public class GameController
{
    private Slime slime;
    private Goblin goblin;

    private void Awake()
    {
        slime.Attack();
        goblin.Attack();
    }
}
public class Slime : Entity
{
    public override void Attack()
    {
        Debug.Log("�������� ����"); //���
    }
}
public class Goblin : Entity
{
    public override void Attack()
    {
        Debug.Log("����� ����"); //���
    }
}
*/

/* //is as ������ ��
public class Entity
{
    public void Attack()
    {
        Debug.Log("���� �����Ѵ�.");
    }
}
public class Slime : Entity
{
}
public class Goblin : Entity
{
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Entity entity = new Slime();
        if (entity is Slime)
        {
            Debug.Log("Entity type is Slime");
        }

        Goblin goblin = entity as Goblin;
        if (goblin == null)
        {
            Debug.Log("goblin is null");
        }
    }
}
*/


/* //�߻� Ŭ���� ��
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target); //�߻� �޼ҵ�
    public void TakeDamage(int damage)
    {
        if currentHP > damage
        {
            currentHP -= damage;
            Debug.Log($"ü���� {damage}����");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}
public class Goblin : Entity
{
    public Goblin(int damage, int hp)
    {
        base.damage = damage;//������ �����Ƿ� base �ʿ�
        currentHP = hp;
    }

    public override void Attack(Entity target)
    {
        Debug.Log("����� ����!");
        target.TakeDamage(damage);
    }
}
public class Slime : Entity
{
    public Slime(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }
    public override void Attack(Entity target)
    {
        Debug.Log("�������� ����!");
        target.TakeDamage(damage);
    }
}
*/

/* //�������̽� ��
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}
public class Slime : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �� �̵�");
    }
}
public class Butterfly : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� ���Ƽ� �̵�");
    }
}
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;

    private void Awake()
    {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector3(4, 5, 6));
        butterfly.MoveTo(new Vector3(7, 8, 9));
    }
}
*/

/* //�Ű������� �������̽� Ÿ��
 * �޼ҵ� ȣ�� �� �������̽��� ������ Ŭ������ �ν��Ͻ��� �Ű������� ����
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private void Awake()
    {
        goblin = new Goblin();
        Method(goblin);
    }

    public void Method(IMovingEntity entity)
    {
    }
}
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}
*/
/* //��ȯŸ���� �������̽� Ÿ��
 * �޼ҵ尡 �ش� �������̽��� ������ Ŭ������ �ν��Ͻ��� ��ȯ
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;

    private void Awake()
    {
        goblin = Method();
    }

    public IMovingEntity Method()
    {
        Goblin goblin = new Goblin();

        return Goblin();
    }
}
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}
*/

/* //�������̽��� ����ϴ� �������̽� ��
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
interface IPerson : IMovingEntity
{
    void Talk(string word);
}

public class Goblin : IMovingEntity //IMocingEntity ���, MoveTo ����
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}

public class Player : IPerson //IPerson ���, MoveTo, Talk ����
{
    private string ID = "�̸�";

    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{ID}���� {destination}���� �̵�");
    }

    public void Talk(string word)
    {
        Debug.Log($"{ID} : {word}");
    }
}

public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IPerson player;

    private void Awake()
    {
        goblin = new Goblin();
        player = new Player();

        goblin.MoveTo(new Vector3(1, 2, 3));
        player.MoveTo(new Vector3(4, 5, 6));
        player.Talk("�ȳ��ϼ���");
    }
}
*/


/* //�������̽��� ���� ���
interface IMovingEntity
{
    void Move(Vector3 destination);
}

interface ICombatEntity
{
    void Attack(Entity target);
}

public class Player : IMovingEntity, ICombatEntity
{
    public void Move(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }

    public void Attack(Entity target)
    {
        Debug.Log($"{target}�� �����մϴ�.");
    }
}
*/

/* //����� �ƴ� ������� �ٸ� Ŭ������ ��� ���
 * Ŭ������ ���� ��� �Ұ���
public class Player
{
    private Berserker berserker;
    private Archer archer;

    private void Awake()
    {
        berserker = new Berserker();
        archer = new Archer();
    }

    public void SwordAttack() {berserker.Sword(); }
    public void ArrowAttack() { archer.Arrow(); }
}
*/








/* //�޼ҵ� ����� ��
public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}
public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("Child");
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child(); //�ڽ� �޼ҵ�
        c.Method01();

        Parent pc = new Child(); //�θ� �޼ҵ�
        pc.Method01();
    }
}
*/

/* //�������̵� �����ϱ�
 * �޼ҵ带 �������̵�   
public class Entity
{
    public virtual void AttackDamage(int damage)
    {
        Debug.Log($"Entity : {damage}��ŭ ü�� ����");
    }
}
public class MovingEntity : Entity
{
    public override void AttackDamage(int damage) //sealed Ű���� �߰��� ���� �߻�
    {
        Debug.Log($"gEntity : {damage}��ŭ ü�� ����");
    }
}
public class Player : MovingEntity
{
    public override void AttackDamage(int damage)
    {
        Debug.Log($"Entity : {damage}��ŭ ü�� ����");
    }
}
*/


/* //��ø Ŭ����
public class OuterClass
{
    public class InnerClass
    {
    }
}
*/
/* //���� Ŭ����
//����1
public partial class Player
{
    public void CounterAttack()
}
//����2
public partial class Player
{
    public void TakeDamage(int damage)
    {
        //ü�� ����
        CounterAttack(); //���� Ŭ�����̹Ƿ� ȣ�� ����
}
*/

/* //����ü ��
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02; //����ü ������ new�� ������ ������ ���� �ʱ�ȭ �ʿ�

        player02.ID = "�̸�";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"ID : {player01.ID}, ü�� : {player01.currentHP}, ���ݷ� : {player01.damage}");
        Debug.Log($"ID : {player02.ID}, ü�� : {player02.currentHP}, ���ݷ� : {player02.damage}");
    }
}
public struct Stats
{
    public string ID;
    public int currentHP;
    public int damage;
}
*/

/* //Ʃ�� ��
var a = ("�̸�", 20);
Debug.Log($"{a.Item1}, {a.Item2}");
 */



/* //���� �޼ҵ� ��
public class Enemy
{
    public int InstanceRun() {return 1;} //�ν��Ͻ� �޼ҵ�

    public static int StaticRun() //���� �޼ҵ�
    {
        InstanceRun(); //���� �޼ҵ忡�� �ν��Ͻ� �޼ҵ� ȣ�� �Ұ���
        return 1;
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        int j = Enemy.StaticRun();//���� �޼ҵ� ȣ��

        Enemy enemy01 = new Enemy();
        int i = enemy01.InstanceRun();//�ν��Ͻ� �޼ҵ� ȣ��

        enemy01.StaticRun(); //�ν��Ͻ��� ���� �޼ҵ� ȣ�� �Ұ���
    }
}
*/

/* //���� ���� ��
public class Enemy
{
    public int numeric; //�ν��Ͻ� ����
    public static string species; //���� ����
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Enemy enemy01 = new Enemy(); //�ν��Ͻ� ���� ���
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy.species = "���"; //���� ���� ���
        Debug.Log(Enemy.species);
    }
}
*/

/* //���� Ŭ����
public static class Calculator
{
    public static int num;

    static Calculator()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
public class GameController
{
    private void Awake()
    {
        Debug.Log(Calculator.Sum(20, 55)); //���� Ŭ������ �޼ҵ� ȣ��  
        Debug.Log(Calculator.num); //���� Ŭ������ ���� ȣ��
    }
}
*/


/* //Ȯ�� �޼ҵ� ��
public static class StringExtension //string Ŭ������ Ȯ�� �޼ҵ� �߰��ϴ� ����
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        string str = "�ȳ��ϼ���.";
        str.PrintData(); //Ȯ�� �޼ҵ� ȣ��
    }
}
*/


/* //�̸����� ��
namespace MySpace //�̸����� ����
{
    public class Player
    {
        //����, �޼ҵ�
    }
}
namespace YourSpace //�̸����� ����
{
    public class Player
    {
        //����, �޼ҵ�
    }
}
using MySpace; //�̸������� Ŭ����, ����ü ���

public class GameController
{
    private void Awake()
    {
        Player player01; //MySpace�� Player Ŭ���� ���
        YourSpace.Player player02 //YourSpace�� Player Ŭ���� ���
    }
}
*/




/* //��� ������ ���м��� ���� Get, Set ��� �Լ� ���
public class Player
{
    private int currentHP;
    private int GetCurrentHP() { return currentHP; }
    private int SetCurrentHP(int hp) { currentHP = hp; }
}
public class GameControlle
{
    private void Awake()
    {
        Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"Player HP : {player.GetCurrentHP()});
    }
}
*/


/* //������Ƽ ����
//get �����ڴ� ��� �����κ��� �� �б�
//set �����ڴ� ��� ������ �� �Ҵ�
//set ������ ���� value Ű����� set �������� �Ϲ��� �Ű�����
pubic class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
        set
        {
            if (currentHP > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
    }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.CurrentHP}");
        player.CurrentHP = -100;
        Debug.Log($"Player HP : {player.CurrentHP}");
    }
}
*/

/* //�ڵ� ���� ������Ƽ ��
public class Player
{
    public int CurrentHP
    {
        get; set; 
    }
    public string ID
    {
        get; set;
    }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.ID = "�̸�";
        player.CurrentHP = 100;
        Debug.Log($"{player.ID} : {player.CurrentHP}");
    }
}
*/

/* //�б� ���� ������Ƽ
pubilc class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
    }
}
*/
/* //���� ���� ������Ƽ
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        set => currentHP = value;
    }
}
*/

/* //private ���������ڷ� ���� Ŭ���� ���ο����� get, set ������Ƽ ��� �����ϵ��� ����
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        private set => currentHP = value;
       get => currentHP;
    }
}
public class Player
{
    pubilc int CurrentHP
    {
        private set; get;
    }
*/


/* //�������̽�  ������Ƽ ��
interface IBaseEnity
{
    strinf ID { get; set; }
    int damage { get; set; }
    int CurrentHP { get; set; }
}
public class Player : IBaseObject
{
    private string id;
    public string ID
    {
        get => id;
        set => id = value;
    }
    public int Damage
    {
        get; set; 
    }
    public int CurrentHP
    {
        get; set;
    }
}
*/


/* //�߻� Ŭ���� ������Ƽ ��
public abstract class BaseEntity
{
    abstract public int Shield
    {
        get; set;
    }
    public int Defense
    {
        get; set;
    }
}
public class Player : BaseEntity
{
    public override int Shield
    {
        get; set;
    }
    public int ID
    {
        get; set;
    }
}

pubic class GameController
{
    private void Awake()
    {
        Player player = new Player();
        {
            player.ID = "�̸�";
            player.Shield = 50;
            player.Defense = 10;
        };

        Debug.Log($"ID : {player.ID}");
        Debug.Log($"���� : {player.Defense}, �� : {player.Shield}");
    }
}
*/