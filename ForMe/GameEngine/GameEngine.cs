namespace ForMe.GameEngine;

enum GameState
{
    Menu,
    Playing,
    Exit
}


public class GameEngine
{
    private Game game = new Game();
    private bool isRunning = true;
    private GameState state = GameState.Playing;
    
    public void Run()
    {
        while (isRunning)
        {
            Update();
        }
    }

    private void Update()
    {
        switch (state)
        {
            case GameState.Menu:
                Menu();
                break;
            
            case GameState.Playing:
                game.Playing();
                break;
            
            case GameState.Exit:
                Exit();
                break;
                
        }    
    }

    private void Menu()
    {
        Console.WriteLine("=== Menu ====");
        
        Console.WriteLine("For playing type 1");
        Console.WriteLine("for exit type 2");
    
    
        int input = int.Parse(Console.ReadLine());

        switch (input) 
        {
            case 1:
                state = GameState.Playing;
                break;
            
            case 2:
                state = GameState.Exit;
                break;
            default:
                state = GameState.Exit;
                break;
        }
    }

    private void Exit()
    {
        Console.WriteLine("Bye Bye");
        isRunning = false;
        return;
    }

   
}