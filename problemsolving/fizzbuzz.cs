using System;
class program{

    static void printfizzbuzz(){

        int endnum  = 100;

        for(int k = 1; k<=endnum; k++){
            if(k%3 == 0 && k%5 == 0 ){
                Console.Write("FizzBuzz ");
            }
            else if(k%3== 0){
                Console.Write("Fizz ");
            }
            else if(k%5 == 0){
                Console.Write("buzz ");
            }

            else{
                Console.Write( $"{k} ");
            }
        }
    }

    static void Main(){
        program.printfizzbuzz();
    }
}