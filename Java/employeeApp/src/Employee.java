public class Employee implements Comparable{
    private String fullName;
    private Double salary;

    public Double getSalary() {
        return salary;
    }

    public String getFullName(){
        return fullName;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    public void setSalary(Double salary) {
        this.salary = salary;
    }

    public Employee(String fullName, Double salary) {
        this.fullName = fullName;
        this.salary = salary;
    } 
    @Override
    public String toString(){
        return getFullName() + " " + getSalary(); 
    }

    @Override
    public int compareTo(Object other) {
        if(other instanceof Employee){
            Employee emp = (Employee)other;
            // return this.getFullName().compareTo(emp.getFullName());
            // return (int) Math.round((this.getSalary()-emp.getSalary()));
            // return (int)this.getSalary().compareTo(emp.getSalary());
            return -this.getSalary().compareTo(emp.getSalary());


        }
        throw new UnsupportedOperationException("An error occured'");
    }
    
}
