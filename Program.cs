DisplayMenu();

string userInput = GetUserInput();
RouteEm(userInput);
while (userInput != "3")
{
    DisplayMenu();
    userInput = GetUserInput();
    RouteEm(userInput);
}

static void DisplayMenu()
{
    
    Console.WriteLine("1.plain pizza \n2. cheese pizza \n3. pep pizza \n4.exit ");
}
static string GetUserInput()
{
    return Console.ReadLine();
}

static void RouteEm(string userInput)
{
    switch (userInput)
    {
        case "1":
            PlainPizza();
            break;

        case "2":
            CheesePizza();
            break;

        case "3":
        PepPizza();
        break;

        case "4":
            Exit();
            break;

        default:
            DisplayErrorMessage();
            break;

    }

}
static void PlainPizza(){
Random random = new Random();
 int randomRows = random.Next(8,13);
 Console.WriteLine($"Plain pizza {randomRows} x12");
 for(int i = randomRows; i >= 1; i--){
  for(int j =1; j <= i ; j++){
        Console.Write("*"+ "\t");
    }
     Console.WriteLine();
 }
}

static void CheesePizza(){
    Random random = new Random();
 int randomRows = random.Next(8,13);
 Console.WriteLine($"Cheese pizza {randomRows} x12");
 for(int i = randomRows; i >= 1; i--){
  for(int j =1; j <= i ; j++){
    if(i == randomRows){
        Console.Write("*");

    }
       else if(j == 1) {
        Console.Write("*");

       }else if(j == i){
        Console.Write("*");
       }
       else{
        Console.Write("#");
       }

       }
            Console.WriteLine();
        }
    
        
   
 }
 
 


static void PepPizza(){
   Random random = new Random();
 int randomRows = random.Next(8,13);
 Console.WriteLine($"pep pizza {randomRows} x12");
 for(int i = randomRows; i >= 1; i--){
  for(int j =1; j <= i ; j++){
    if(i == randomRows){
        Console.Write("*");

    }
       else if(j == 1) {
        Console.Write("*");

       }else if(j == i){
        Console.Write("*");
       }
       
       else{// check if chesse or pepperioni
        int chance = random.Next(1,3);
        if(chance ==1){
            Console.Write(" [] ");
        }
        else{
            Console.Write(" # ");
        }

       }

       }
            Console.WriteLine();
        }
    
        
   
 }



static void Exit(){
    Console.WriteLine("exiting the program");
}
static void DisplayErrorMessage(){
    Console.WriteLine("invalid expression try again");
}