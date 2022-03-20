using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stufful Species to store common natural stats of all Stuffuls
	#region StuffulSpecies
	public class StuffulSpecies : PokemonSpecies
	{
#nullable enable
		private static StuffulSpecies? _instance = null;
#nullable restore
        public static StuffulSpecies Instance => _instance ?? (_instance = new StuffulSpecies());

		#region StuffulSpecies Constructor
		public StuffulSpecies() : base(
			759,
			"Stufful",
			Normal.Instance, Fighting.Instance,
			0.5,
			6.8,
			new PokemonStats(
				70, // HPs
				75, 50, // Attack & Defense
				45, 50, // Spacial Attack & Defense
				50 // Speed
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
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Mega-Kick",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flail",
				"Protect",
				"Endure",
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
				"Bulk-Up",
				"Hammer-Arm",
				"Payback",
				"Fling",
				"Force-Palm",
				"Focus-Blast",
				"Wide-Guard",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}