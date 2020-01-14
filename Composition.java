class Fest {
    private String role;
    private long budget;
    private int id;
        
    public String getRole() {
        return role;
    }
    public void setRole(String role) {
        this.role = role;
    }
    public long getBudget() {
        return budget;
    }
    public void setBudget(long budget) {
        this.budget = budget;
    }
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }    
}

class Organizer {
    private Fest fest;
   
    public Organizer(){
        this.fest=new Fest();
        fest.setBudget(25000L);
    }
    public long getBudget() {
        return fest.getBudget();
    }
}

public class Composition {

    public static void main(String[] args) {
        Organizer organizer = new Organizer();
        long budget = organizer.getBudget();
    }

}