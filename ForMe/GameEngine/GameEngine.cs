namespace ForMe.GameEngine;

enum GameState
{
    Menu,
    Playing,
    Exit
}


public class GameEngine
{
    private readonly Game _game = new Game();
    private bool _isRunning = true;
    private GameState _state = GameState.Playing;
    
    public void Run()
    {
        while (_isRunning)
        {
            Update();
        }
    }

    private void Update()
    {
        switch (_state)
        {
            case GameState.Menu:
                Menu();
                break;
            
            case GameState.Playing:
                _game.Playing();
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
                _state = GameState.Playing;
                break;
            
            case 2:
                _state = GameState.Exit;
                break;
            default:
                _state = GameState.Exit;
                break;
        }
    }

    private void Exit()
    {
        Console.WriteLine("Bye Bye");
        _isRunning = false;
    }

   
}