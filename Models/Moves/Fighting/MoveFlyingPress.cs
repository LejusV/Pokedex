using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Deals both fighting and flying-type damage.
	public class MoveFlyingPress : Move
	{
#nullable enable
		private static MoveFlyingPress? _instance = null;
#nullable restore
        public static MoveFlyingPress Instance => _instance ?? (_instance = new MoveFlyingPress());

		public MoveFlyingPress() : base(
			"Flying-Press",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}