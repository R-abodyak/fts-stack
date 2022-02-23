class myStack <T> : List<T> {
private T data ;

List <T> list ;
public myStack () {
   list = new List<T>();
}

public void Push( T element ){
  list.Add(element);
  
}
public void Pop(){
    if(list.Count==0){
        Console.Write("Pop invalid :Empty Stack  \n");
    }
    else {
         list.RemoveAt(list.Count-1);

    }
 
}
public void Print () {
    if (list.Count ==0){
        Console.Write("Empty stack \n");
    }
    else {
        for (int i=0;i<list.Count -1 ;i++){
           Console.Write(list[i]+"," );
    }
        Console.Write(list[list.Count -1]+"\n");
}
}


public void Peak(){
    if (list.Count ==0){
        Console.Write("Nothing to peak \n");
    }
    else {
        Console.Write(list[list.Count -1]+"\n");
    }
}

public void Clear (){
     //Console.Write("Inhertance MY NEW METHOD ");
     if(list.Count==0){
         Console.Write("Already clear   \n");
     }
    list.Clear();
}

}

class Test {

public static void Main () {
myStack <int>  s = new myStack <int>();
s.Push(5);
s.Push(7);
s.Push(9);
s.Pop();
s.Print();
s.Peak();
myStack <string>  s2 = new myStack <string>();
s2.Pop();
s2.Print();
s2.Peak();
s2.Push("Ali"); 
s2.Push("Muna");
s2.Push("Ahmed");
s2.Print();
s2.Peak();
s2.Clear();
s2.Print();
myStack <int>  s3 = new myStack <int>();
s3.Clear();

}


}