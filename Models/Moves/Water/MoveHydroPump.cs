using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHydroPump : Move
	{
#nullable enable
		private static MoveHydroPump? _instance = null;
#nullable restore
        public static MoveHydroPump Instance => _instance ?? (_instance = new MoveHydroPump());

		public MoveHydroPump() : base(
			"Hydro-Pump",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}