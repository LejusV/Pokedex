using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveLashOut : Move
	{
#nullable enable
		private static MoveLashOut? _instance = null;
#nullable restore
        public static MoveLashOut Instance => _instance ?? (_instance = new MoveLashOut());

		public MoveLashOut() : base(
			"Lash-Out",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}