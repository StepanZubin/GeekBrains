package OOP.Lecture_1.Ex004;

public class Robot2 {
    /**уровень робота */
    private int level;

    /**имя робота */
    private String name;

    /**
     * создание робота
     * @param name Имя робота (! не должно начинаться с цифры)
     * @param level Уровень робота
     */
    public Robot2(String name, int level) {
        this.name = name;
        this.level = level;
    }

    // Методы вкл/выкл подсистем

    // описание кнопок вместо методов
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
 
    // отдельные методы: только на чтение
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
    public void work() {System.out.println("working ...");}

}
