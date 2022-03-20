using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSkitterSmack : Move
	{
#nullable enable
		private static MoveSkitterSmack? _instance = null;
#nullable restore
        public static MoveSkitterSmack Instance => _instance ?? (_instance = new MoveSkitterSmack());

		public MoveSkitterSmack() : base(
			"Skitter-Smack",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}