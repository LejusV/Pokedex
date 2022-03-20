using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bewear Species to store common natural stats of all Bewears
	#region BewearSpecies
	public class BewearSpecies : PokemonSpecies
	{
#nullable enable
		private static BewearSpecies? _instance = null;
#nullable restore
        public static BewearSpecies Instance => _instance ?? (_instance = new BewearSpecies());

		#region BewearSpecies Constructor
		public BewearSpecies() : base(
			760,
			"Bewear",
			Normal.Instance, Fighting.Instance,
			2.1,
			135.0,
			new PokemonStats(
				120, // HPs
				125, 80, // Attack & Defense
				55, 60, // Spacial Attack & Defense
				60 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Bind",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flail",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Bulk-Up",
				"Hammer-Arm",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}