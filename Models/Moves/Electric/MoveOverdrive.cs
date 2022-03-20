using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveOverdrive : Move
	{
#nullable enable
		private static MoveOverdrive? _instance = null;
#nullable restore
        public static MoveOverdrive Instance => _instance ?? (_instance = new MoveOverdrive());

		public MoveOverdrive() : base(
			"Overdrive",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}