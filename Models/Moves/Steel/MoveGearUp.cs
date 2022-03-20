using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the Attack and Special Attack of all friendly Pokémon with plus or minus by one stage.
	public class MoveGearUp : Move
	{
#nullable enable
		private static MoveGearUp? _instance = null;
#nullable restore
        public static MoveGearUp Instance => _instance ?? (_instance = new MoveGearUp());

		public MoveGearUp() : base(
			"Gear-Up",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}