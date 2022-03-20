using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveHeartStamp : Move
	{
#nullable enable
		private static MoveHeartStamp? _instance = null;
#nullable restore
        public static MoveHeartStamp Instance => _instance ?? (_instance = new MoveHeartStamp());

		public MoveHeartStamp() : base(
			"Heart-Stamp",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}