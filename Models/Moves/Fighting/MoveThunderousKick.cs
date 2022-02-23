using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveThunderousKick : Move
	{
		public MoveThunderousKick() : base(
			"Thunderous-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}