using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Elekid Species to store common natural stats of all Elekids
	#region ElekidSpecies
	public class ElekidSpecies : PokemonSpecies
	{
#nullable enable
		private static ElekidSpecies? _instance = null;
#nullable restore
        public static ElekidSpecies Instance => _instance ?? (_instance = new ElekidSpecies());

		#region ElekidSpecies Constructor
		public ElekidSpecies() : base(
			239,
			"Elekid",
			Electric.Instance,
			0.6,
			23.5,
			new PokemonStats(
				45, // HPs
				63, 37, // Attack & Defense
				65, 55, // Spacial Attack & Defense
				95 // Speed
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
				"Karate-Chop",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Rolling-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Meditate",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Magnet-Rise",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}