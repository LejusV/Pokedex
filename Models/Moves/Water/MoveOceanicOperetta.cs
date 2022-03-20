using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveOceanicOperetta : Move
	{
#nullable enable
		private static MoveOceanicOperetta? _instance = null;
#nullable restore
        public static MoveOceanicOperetta Instance => _instance ?? (_instance = new MoveOceanicOperetta());

		public MoveOceanicOperetta() : base(
			"Oceanic-Operetta",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 195,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}