using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense and Special Defense by one stage.
	public class MoveCosmicPower : Move
	{
#nullable enable
		private static MoveCosmicPower? _instance = null;
#nullable restore
        public static MoveCosmicPower Instance => _instance ?? (_instance = new MoveCosmicPower());

		public MoveCosmicPower() : base(
			"Cosmic-Power",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}