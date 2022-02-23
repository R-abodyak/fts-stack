class myStack <T> : List<T> {
private T data ;
private int counter = 0 ; 
List <T> list ;
public myStack () {
   list = new List<T>();
}

public void push( T element ){
  list.Add(element);
  counter++;

}



}

class Test {

public static void main () {
myStack <int>  s = new myStack <int>();

}


}