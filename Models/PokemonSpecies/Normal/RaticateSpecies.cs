using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Raticate Species to store common natural stats of all Raticates
	#region RaticateSpecies
	public class RaticateSpecies : PokemonSpecies
	{
#nullable enable
		private static RaticateSpecies? _instance = null;
#nullable restore
        public static RaticateSpecies Instance => _instance ?? (_instance = new RaticateSpecies());

		#region RaticateSpecies Constructor
		public RaticateSpecies() : base(
			20,
			"Raticate",
			Normal.Instance,
			0.7,
			18.5,
			new PokemonStats(
				55, // HPs
				81, 60, // Attack & Defense
				50, 70, // Spacial Attack & Defense
				97 // Speed
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
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
				"Endeavor",
				"Secret-Power",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Pluck",
				"U-Turn",
				"Assurance",
				"Last-Resort",
				"Sucker-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}