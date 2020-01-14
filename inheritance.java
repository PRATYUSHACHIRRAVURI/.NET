class Human
{
    int age,id;
    String name;
    void set_name(String name)
    {
        System.out.println("Name:"+name);
    }
}
class Employee extends Human
{
    void set_age(int age)
    {
        System.out.println("Age of employee is:"+age);
    }
}
public class Main
{
    public static void main(String [] er)
    {
        Employee e= new Employee();
        e.set_name("Pratyusha");
        e.set_age(21);
    }
    
}