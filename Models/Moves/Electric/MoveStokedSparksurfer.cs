using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to paralyze the target.
	public class MoveStokedSparksurfer : Move
	{
#nullable enable
		private static MoveStokedSparksurfer? _instance = null;
#nullable restore
        public static MoveStokedSparksurfer Instance => _instance ?? (_instance = new MoveStokedSparksurfer());

		public MoveStokedSparksurfer() : base(
			"Stoked-Sparksurfer",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 175,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}