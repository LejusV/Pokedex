using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveJungleHealing : Move
	{
#nullable enable
		private static MoveJungleHealing? _instance = null;
#nullable restore
        public static MoveJungleHealing Instance => _instance ?? (_instance = new MoveJungleHealing());

		public MoveJungleHealing() : base(
			"Jungle-Healing",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}