using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pikachu Species to store common natural stats of all Pikachus
	#region PikachuSpecies
	public class PikachuSpecies : PokemonSpecies
	{
#nullable enable
		private static PikachuSpecies? _instance = null;
#nullable restore
        public static PikachuSpecies Instance => _instance ?? (_instance = new PikachuSpecies());

		#region PikachuSpecies Constructor
		public PikachuSpecies() : base(
			25,
			"Pikachu",
			Electric.Instance,
			0.4,
			6.0,
			new PokemonStats(
				35, // HPs
				55, 40, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				90 // Speed
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
				"Pay-Day",
				"Thunder-Punch",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Surf",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
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
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Magnet-Rise",
				"Discharge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Play-Nice",
				"Confide",
				"Nuzzle"
			};
		}
		#endregion
	}
	#endregion
}