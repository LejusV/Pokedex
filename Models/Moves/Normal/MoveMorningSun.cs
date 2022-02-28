using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.  Affected by weather.
	public class MoveMorningSun : Move
	{
		public MoveMorningSun() : base(
			"Morning-Sun",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}