using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//If there be weather, this move has doubled power and the weather's type.
	public class MoveWeatherBall : Move
	{
		public MoveWeatherBall() : base(
			"Weather-Ball",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}