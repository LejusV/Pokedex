using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveDragonDarts : Move
	{
		public MoveDragonDarts() : base(
			"Dragon-Darts",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}