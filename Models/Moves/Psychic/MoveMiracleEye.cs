using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Forces the target to have no evasion, and allows it to be hit by Psychic moves even if it's Dark.
	public class MoveMiracleEye : Move
	{
#nullable enable
		private static MoveMiracleEye? _instance = null;
#nullable restore
        public static MoveMiracleEye Instance => _instance ?? (_instance = new MoveMiracleEye());

		public MoveMiracleEye() : base(
			"Miracle-Eye",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}