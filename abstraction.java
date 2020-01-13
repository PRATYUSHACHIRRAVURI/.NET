abstract class Vending_machine{
 public abstract long get_no_of_items() ;
public abstract void set_no_of_items(long no_of_items) ;
public abstract String getrequest();
public abstract void setrequest(String request) ;
public abstract float getAmount();
public abstract void setAmount(float amount);
}

class Cola extends Vending_machine{
private long no_of_items;  
private String request;
private float amount;
 public long get_no_of_items() {  
    return no_of_items;  
}  
public void set_no_of_items(long no_of_items) {  
    this.no_of_items = no_of_items;  
}  
public String getrequest() {  
    return request;  
}  
public void setrequest(String request) {  
    this.request = request;  
}  
public float getAmount() {  
    return amount;  
}  
public void setAmount(float amount) {  
    this.amount = amount;  
}  
}

class MyMainClass {
  public static void main(String[] args) {
    Cola c = new Cola(); 
    c.set_no_of_items(5);  
    c.setrequest("Yes"); 
    c.setAmount(100);  
    
    System.out.println("The no of items are "+c.get_no_of_items()+"As the request is: "+c.getrequest()+" The amount is:"+c.getAmount());  
  }
}