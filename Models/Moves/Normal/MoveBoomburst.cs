using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.
	public class MoveBoomburst : Move
	{
#nullable enable
		private static MoveBoomburst? _instance = null;
#nullable restore
        public static MoveBoomburst Instance => _instance ?? (_instance = new MoveBoomburst());

		public MoveBoomburst() : base(
			"Boomburst",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 140,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}