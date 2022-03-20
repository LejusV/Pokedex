using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.  Affected by weather.
	public class MoveMorningSun : Move
	{
#nullable enable
		private static MoveMorningSun? _instance = null;
#nullable restore
        public static MoveMorningSun Instance => _instance ?? (_instance = new MoveMorningSun());

		public MoveMorningSun() : base(
			"Morning-Sun",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}