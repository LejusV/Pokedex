using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the target's Attack by two stages and confuses the target.
	public class MoveSwagger : Move
	{
#nullable enable
		private static MoveSwagger? _instance = null;
#nullable restore
        public static MoveSwagger Instance => _instance ?? (_instance = new MoveSwagger());

		public MoveSwagger() : base(
			"Swagger",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}