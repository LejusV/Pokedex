using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Pokémon in the air.
	public class MoveGust : Move
	{
#nullable enable
		private static MoveGust? _instance = null;
#nullable restore
        public static MoveGust Instance => _instance ?? (_instance = new MoveGust());

		public MoveGust() : base(
			"Gust",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			35, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}