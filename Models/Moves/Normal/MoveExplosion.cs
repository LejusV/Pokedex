using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User faints.
	public class MoveExplosion : Move
	{
#nullable enable
		private static MoveExplosion? _instance = null;
#nullable restore
        public static MoveExplosion Instance => _instance ?? (_instance = new MoveExplosion());

		public MoveExplosion() : base(
			"Explosion",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 250,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}