
[Category("Leek Factory")]
[Icon("add_to_queue")]
public class GameManager : Component
{
	public static GameManager Instance = new();
	
	/// <summary>
	/// The local player's money
	/// </summary>
	public double Money { get; set; }
}
