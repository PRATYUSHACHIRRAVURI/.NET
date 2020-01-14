public class Bag{
   int  books;
   int  pens;
    Bag(){
      books = 1;
      pens = 2;
   }
   Bag(int a){
      books = a;
      
   }
  public void display(){
     System.out.println("books === "+books);
     System.out.println("pens === "+pens);
  }
  public static void main(String args[]){
    Extra e1 = new Extra();
     e1.display();
  }
}
class Extra extends Bag{
    int pencil;
    int sheets;
    Extra(){
     pencil = 3;
     sheets = 4;
    }
    public void display(){
      System.out.println("books === "+books+"pens === "+pens+"pencil === "+pencil+"sheets === "+sheets);
   }
}