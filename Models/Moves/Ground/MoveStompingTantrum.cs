using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has double power if the user's last move failed.
	public class MoveStompingTantrum : Move
	{
		public MoveStompingTantrum() : base(
			"Stomping-Tantrum",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}