using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Electabuzz Species to store common natural stats of all Electabuzzs
	#region ElectabuzzSpecies
	public class ElectabuzzSpecies : PokemonSpecies
	{
#nullable enable
		private static ElectabuzzSpecies? _instance = null;
#nullable restore
        public static ElectabuzzSpecies Instance => _instance ?? (_instance = new ElectabuzzSpecies());

		#region ElectabuzzSpecies Constructor
		public ElectabuzzSpecies() : base(
			125,
			"Electabuzz",
			Electric.Instance,
			1.1,
			30.0,
			new PokemonStats(
				65, // HPs
				83, 57, // Attack & Defense
				95, 85, // Spacial Attack & Defense
				105 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Rage",
				"Teleport",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Psywave",
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
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Low-Sweep",
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