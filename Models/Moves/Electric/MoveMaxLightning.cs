using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxLightning : Move
	{
#nullable enable
		private static MoveMaxLightning? _instance = null;
#nullable restore
        public static MoveMaxLightning Instance => _instance ?? (_instance = new MoveMaxLightning());

		public MoveMaxLightning() : base(
			"Max-Lightning",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}