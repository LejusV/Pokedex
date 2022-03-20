using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rattata Species to store common natural stats of all Rattatas
	#region RattataSpecies
	public class RattataSpecies : PokemonSpecies
	{
#nullable enable
		private static RattataSpecies? _instance = null;
#nullable restore
        public static RattataSpecies Instance => _instance ?? (_instance = new RattataSpecies());

		#region RattataSpecies Constructor
		public RattataSpecies() : base(
			19,
			"Rattata",
			Normal.Instance,
			0.3,
			3.5,
			new PokemonStats(
				30, // HPs
				56, 35, // Attack & Defense
				25, 35, // Spacial Attack & Defense
				72 // Speed
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Counter",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Pluck",
				"U-Turn",
				"Assurance",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}