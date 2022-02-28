using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from scoring critical hits for five turns.
	public class MoveLuckyChant : Move
	{
		public MoveLuckyChant() : base(
			"Lucky-Chant",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}