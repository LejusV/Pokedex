using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User becomes the target's type.
	public class MoveReflectType : Move
	{
#nullable enable
		private static MoveReflectType? _instance = null;
#nullable restore
        public static MoveReflectType Instance => _instance ?? (_instance = new MoveReflectType());

		public MoveReflectType() : base(
			"Reflect-Type",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}