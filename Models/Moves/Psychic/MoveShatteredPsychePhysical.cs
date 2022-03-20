using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveShatteredPsychePhysical : Move
	{
#nullable enable
		private static MoveShatteredPsychePhysical? _instance = null;
#nullable restore
        public static MoveShatteredPsychePhysical Instance => _instance ?? (_instance = new MoveShatteredPsychePhysical());

		public MoveShatteredPsychePhysical() : base(
			"Shattered-Psyche--Physical",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}