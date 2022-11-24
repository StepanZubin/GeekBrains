package OOP.Lecture_1.Ex004;

import java.util.ArrayList;

public class Robot3 {

    /**описание 2-х возможных состояний */
    enum State {
        On, Off
    }

    // статические поля (чтобы нельзя было создать 2-а робота с одинаковым именем)
    private static int defaultIndex; // дефолтный индекс для нумерации
    private static ArrayList<String> names; // коллекция имён

    /**статический инициализатор */
    static {
        defaultIndex = 1;
        names = new ArrayList<String>();
    }

    /**уровень робота */
    private int level;

    /**имя робота */
    private String name;

    private State state; // поле - состояние


    private Robot3(String name, int level) {
        if ((name.isEmpty() // если имя робота: пустое
                || Character.isDigit(name.charAt(0))) // или 1-й символ имени робота - цифра
                || Robot3.names.indexOf(name) != -1)  // или такое имя было задано ранее
        {
            this.name = String.format("DefaultName_%d", defaultIndex++); // придумываем какое-то дефолтное имя
        } else {
            this.name = name; // если условия не выполнились - используем имя заданное пользователем
        }
        // добавляем имя в коллекцию при необходимости
        Robot3.names.add(this.name);
        this.level = level; // инициализация уровня
        this.state = State.Off; // инициализация начального состояния
    }

    //#region другие конструкторы---

    //#region правильные конструкторы---


public Robot3(String name) {
    this(name, 1);
}

public Robot3() {
    this(" ");
}


// методы вкл/выкл подсистем
public void power() {
    if (this.state == State.Off) {
        this.powerOn();
        this.state = State.On;
    } else {
        this.powerOff();
        this.state = State.Off;
    }
    System.out.println();
}

public void powerOn() {
    this.startBIOS();
    this.startOS();
    this.sayHi();
}

public void powerOff() {
    this.sayBye();
    this.stopOS();
    this.stopBIOS();
}

public int getLevel() {
    return this.level;
}

public String getName() {
    return this.name;
}

/**загрузка BIOS */
private void startBIOS() {System.out.println("start BIOS ...");}

/**загрузка OS */
private void startOS() {System.out.println("start OS ...");}

/**приветствие */
private void sayHi() {System.out.println("Hello World ...");}

/**выгрузка BIOS */
private void stopBIOS() {System.out.println("stop BIOS ...");}

/**выгрузка OS */
private void stopOS() {System.out.println("stop OS ...");}

/**прощание */
private void sayBye() {System.out.println("Bye ...");}

/**работа */
public void work() {
    if (this.state == State.On) {
        System.out.println("working ...");}
    }    

@Override
public String toString() {
    return String.format("%s %d\n", this.name, this.level);
}

}
