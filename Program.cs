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
public void print () {
    if (list.Count ==0){
        Console.Write("Empty stack ");
    }
    else {
        for (int i=0;i<list.Count -1 ;i++){
           Console.Write(list[i]+"," );
    }
        Console.Write(list[list.Count -1]);


}
}

}

class Test {

public static void Main () {
myStack <int>  s = new myStack <int>();
s.push(5);
s.push(7);
s.push(9);
s.pop();
s.print();


}


}