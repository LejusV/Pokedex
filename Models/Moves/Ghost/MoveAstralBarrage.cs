using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAstralBarrage : Move
	{
		public MoveAstralBarrage() : base(
			"Astral-Barrage",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}