using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePoltergeist : Move
	{
#nullable enable
		private static MovePoltergeist? _instance = null;
#nullable restore
        public static MovePoltergeist Instance => _instance ?? (_instance = new MovePoltergeist());

		public MovePoltergeist() : base(
			"Poltergeist",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 110,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}