using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//After inflicting damage, causes all Normal-type moves to become Electric-type for the remainder of the turn.
	public class MoveLetsSnuggleForever : Move
	{
		public MoveLetsSnuggleForever() : base(
			"Lets-Snuggle-Forever",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 190,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}