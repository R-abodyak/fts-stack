class myStack <T> : List<T> {
private T data ;
private int counter = -1 ; 
List <T> list ;
public myStack () {
   list = new List<T>();
}

public void push( T element ){
  list.Add(element);
  counter++;

}
public void pop(){
    if(counter==-1){
        Console.Write("Empty Stack");
    }
    else {
         list.RemoveAt(counter);
         counter --;

    }
 

}


}

class Test {

public static void main () {
myStack <int>  s = new myStack <int>();
s.Add(5);
s.Add(7);


}


}