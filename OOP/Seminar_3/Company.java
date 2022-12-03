package OOP.Seminar_3;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Company implements Iterable<User> {

    User bigBoss;

    public Company(User user) {
        this.bigBoss = user;
    }

    @Override
    public Iterator<User> iterator() {
        return new Iterator<User>() {
            
            private List<User> employsees = DeepTree(bigBoss);
            private int currentIndex = 0;
            
    
            @Override
            public boolean hasNext() {
                return currentIndex < employsees.size();
            }


            @Override
            public User next() {
                return employsees.get(currentIndex++);
            }


        };
    }
    
    private List<User> DeepTree(User user) {
        List<User> answer = new ArrayList<>();
        answer.add(user);
        if (user.getSubordinates() == null || user.getSubordinates().size() == 0) {
            return answer;
        }

        for (User subordinates : user.getSubordinates()) {
            answer.addAll(DeepTree(subordinates));
        }
        return answer;
    }
}
