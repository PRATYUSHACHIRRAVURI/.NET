
class Vending_machine {  
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

public class TestEncapsulation {  
public static void main(String[] args) {   
    Vending_machine vm=new Vending_machine();   
    vm.set_no_of_items(5);  
    vm.setrequest("Yes"); 
    vm.setAmount(100);  
    
    System.out.println("The no of items are "+vm.get_no_of_items()+"As the request is: "+vm.getrequest()+" The amount is:"+vm.getAmount());  
}  
}