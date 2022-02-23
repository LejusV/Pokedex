using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the target's Attack by two stages and confuses the target.
	public class MoveSwagger : Move
	{
		public MoveSwagger() : base(
			"Swagger",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}