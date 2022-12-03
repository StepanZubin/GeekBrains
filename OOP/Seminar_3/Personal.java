package OOP.Seminar_3;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Personal implements Iterable<User> {

    private List <User> users = new ArrayList<User>();

    public Personal(List <User> users) {
        this.users = users;
    }

    @Override
    public Iterator<User> iterator() {
        //анонимный класс:
        return new Iterator<User>() { 
            private int index = 0;

            @Override
            public boolean hasNext() {
                /* hasNext - проверяет есть ли следующий элемент;
                возвращает либо try, либо false */
                return index < users.size();
            }

            @Override
            public User next() {
                return users.get(index++);
            } 
            
        };
    }

    public Integer size() {
        return users.size();
    }
    
    
}
