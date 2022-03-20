using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Reduces damage from physical attacks by half.
	public class MoveReflect : Move
	{
#nullable enable
		private static MoveReflect? _instance = null;
#nullable restore
        public static MoveReflect Instance => _instance ?? (_instance = new MoveReflect());

		public MoveReflect() : base(
			"Reflect",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}