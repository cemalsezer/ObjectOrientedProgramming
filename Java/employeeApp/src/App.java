import java.util.List;
import java.util.Arrays;
import java.util.Collections;

public class App {
    public static void main(String[] args) throws Exception {
        List<Employee> enEmployees = Arrays.asList(
            new Employee("Zizu", 20d),
        new Employee("Ronaldo", 22d),
        new Employee("Cristiano", 26d),
        new Employee("Messi", 25d),
        new Employee("Ronaldinho", 20d));

        writeList(enEmployees);

        Collections.sort(enEmployees);
        System.out.println("----");
        
        writeList(enEmployees);
    }

    private static void writeList(Iterable collection){
        for(Object item: collection)
            System.out.println(item);
    }
}
