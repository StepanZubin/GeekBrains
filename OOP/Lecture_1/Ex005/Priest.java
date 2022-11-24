package OOP.Lecture_1.Ex005;

import java.util.Random;

public class Priest {
    private static final String HERO_PRIEST_D = "Hero_Priest #%d";
    private static int number;
    private static Random r;

    // состояния
    private String name;
    private int hp;
    private int maxHp;

    private int elixir;
    private int maxElixir;

    static {
        Priest.number = 0;
        Priest.r = new Random();
    }

    public Priest (String name, int hp, int elixir) {
        this.name = name;
        this.hp = hp;
        this.maxHp = maxHp;
        this.elixir = elixir;
        this.maxElixir = maxElixir;
    }

    // конструктор
    public Priest() {
        this (String.format(HERO_PRIEST_D, ++Priest.number),
        Priest.r.nextInt(200),
        Priest.r.nextInt(150));
    }

    // метод атаки
    public int Attack() {
        int damage = Priest.r.nextInt(30);
        this.elixir -= (int)(damage * 0.0);
        if (elixir < 0) return 0;
        else return damage;
    }

    // метод получения информации
    public String getInfo() {
        return String.format("Name: %s Hp: %d Elixir: %d Type: %s", 
                this.name, this.hp, this.elixir, this.getClass().getSimpleName());
    }

    // метод лечения
    public void healed (int Hp) {
        this.hp = Hp + this.hp > this.maxHp ? this.maxHp : Hp + this.hp;
    }

    // метод прлучения урона
    public void GetDamage (int damage) {
        if (this.hp - damage > 0) {
            this.hp -= damage;
        }
        // else { die(); } 
    }
}
