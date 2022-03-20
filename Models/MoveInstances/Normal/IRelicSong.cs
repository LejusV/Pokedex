using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRelicSong : MoveInstance
	{
		public IRelicSong() : base( MoveRelicSong.Instance ) {}
	}
}