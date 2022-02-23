using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveLifeDew : Move
	{
		public MoveLifeDew() : base(
			"Life-Dew",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}