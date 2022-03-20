using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveShatteredPsycheSpecial : Move
	{
#nullable enable
		private static MoveShatteredPsycheSpecial? _instance = null;
#nullable restore
        public static MoveShatteredPsycheSpecial Instance => _instance ?? (_instance = new MoveShatteredPsycheSpecial());

		public MoveShatteredPsycheSpecial() : base(
			"Shattered-Psyche--Special",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}