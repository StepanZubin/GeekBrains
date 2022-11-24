package OOP.Lecture_1.Ex004;

public class Robot1 {
    /**уровень робота */
    public int level;

    /**имя робота */
    public String name;

    /**
     * создание робота
     * @param name Имя робота (! не должно начинаться с цифры)
     * @param level Уровень робота
     */
    public Robot1(String name, int level) {
        this.name = name;
        this.level = level;
    }

    // Методы вкл/выкл подсистем

    /**загрузка BIOS */
    public void startBIOS() {System.out.println("start BIOS ...");}

    /**загрузка OS */
    public void startOS() {System.out.println("start OS ...");}

    /**приветствие */
    public void sayHi() {System.out.println("Hello World ...");}

    /**выгрузка BIOS */
    public void stopBIOS() {System.out.println("stop BIOS ...");}

    /**выгрузка OS */
    public void stopOS() {System.out.println("stop OS ...");}

    /**прощание */
    public void sayBye() {System.out.println("Bye ...");}

    /**работа */
    public void work() {System.out.println("working ...");}

}
