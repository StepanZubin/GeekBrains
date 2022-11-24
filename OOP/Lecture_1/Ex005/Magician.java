package OOP.Lecture_1.Ex005;

import java.util.Random;

public class Magician {
    private static int number;
    private static Random r;

    private String name;
    private int hp;
    private int maxHp;

    private int mana;
    private int maxMana;

    static {
        Magician.number = 0;
        Magician.r = new Random();
    }

    //конструктор
    public Magician (String name, int hp, int mana) {
        this.name = name;
        this.hp = hp;
        this.maxHp = hp;
        this.mana = mana;
        this.maxMana = mana;
    }

    public Magician() {
        this(String.format("Hero_Magician #%d", ++Magician.number),
                Magician.r.nextInt(200),
                Magician.r.nextInt(150));
    }

    //механизм атаки
    public int Attack() {
        int damage = Magician.r.nextInt(30);
        this.mana -= (int)(damage * 0.0);
        if (mana < 0) return 0;
        else return damage;
    }


    // метод получения информации    
    public String getInfo() {
        return String.format("Name: %s Hp: %d Enegry: %d Type: %s", 
            this.name, this.hp, this.mana, this.getClass().getSimpleName());
    }

    // метод лечения персонажа
    public void healed (int Hp) {
        this.hp = Hp + this.hp > this.maxHp ? this.maxHp : Hp + this.hp;
    }

    // метод получения урона
    public void GetDamage (int damage) {
        if (this.hp - damage > 0) {
            this.hp -= damage;
        }
        // else { die(); }
    }
}
