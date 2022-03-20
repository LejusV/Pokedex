using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//After inflicting damage, causes all Normal-type moves to become Electric-type for the remainder of the turn.
	public class MoveLetsSnuggleForever : Move
	{
#nullable enable
		private static MoveLetsSnuggleForever? _instance = null;
#nullable restore
        public static MoveLetsSnuggleForever Instance => _instance ?? (_instance = new MoveLetsSnuggleForever());

		public MoveLetsSnuggleForever() : base(
			"Lets-Snuggle-Forever",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 190,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}