package OOP.Seminar_4;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Team<T extends Warrior> implements Iterable<T> { //команда (<T extends Warrior> - ничего кроме Warrior)
                                            //Iterable перебирает List 
                                            //<...> дженерик - нужен для контроля типов воинов в команде
                                            //Iterable делает foreach (без него не получиться)
    private Hero hero;
    private List<T> teamList = new ArrayList<>(); //список участников команды

    public Team(Hero hero) {
        this.hero = hero;
    }

    public void add(T pers) {
        teamList.add(pers);
    }

    @Override
    public Iterator<T> iterator() {
        return teamList.iterator();
    }

    @Override
    public String toString() {
        StringBuilder bild = new StringBuilder(hero.toString() + "\n");
        for (T item : this) { //"this" - означает экземпляр "этого" класса, к-й сейчас в работе (Team<T extends Warrior>)
            bild.append(item.toString() + "\n");
        }
        return bild.toString();
    }

    public Integer getTeamHelsPoint() { //общие жизни
        int sum = hero.getHealthPoint(); //присвоили здоровье "hero" - т.к. в foreach его не будет
        for (T member : this) { //member - переменная
            sum += member.getHealthPoint(); //.getHealthPoint() - жизнь итерируемрго героя
        }
        return sum;
    }
}