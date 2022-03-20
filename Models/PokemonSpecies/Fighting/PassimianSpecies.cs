using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Passimian Species to store common natural stats of all Passimians
	#region PassimianSpecies
	public class PassimianSpecies : PokemonSpecies
	{
#nullable enable
		private static PassimianSpecies? _instance = null;
#nullable restore
        public static PassimianSpecies Instance => _instance ?? (_instance = new PassimianSpecies());

		#region PassimianSpecies Constructor
		public PassimianSpecies() : base(
			766,
			"Passimian",
			Fighting.Instance,
			2.0,
			82.8,
			new PokemonStats(
				100, // HPs
				120, 90, // Attack & Defense
				40, 60, // Spacial Attack & Defense
				80 // Speed
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
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Seismic-Toss",
				"Earthquake",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Gyro-Ball",
				"Feint",
				"U-Turn",
				"Close-Combat",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Iron-Head",
				"Grass-Knot",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Bestow",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}