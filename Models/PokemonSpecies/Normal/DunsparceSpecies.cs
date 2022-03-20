using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dunsparce Species to store common natural stats of all Dunsparces
	#region DunsparceSpecies
	public class DunsparceSpecies : PokemonSpecies
	{
#nullable enable
		private static DunsparceSpecies? _instance = null;
#nullable restore
        public static DunsparceSpecies Instance => _instance ?? (_instance = new DunsparceSpecies());

		#region DunsparceSpecies Constructor
		public DunsparceSpecies() : base(
			206,
			"Dunsparce",
			Normal.Instance,
			1.5,
			14.0,
			new PokemonStats(
				100, // HPs
				70, 70, // Attack & Defense
				65, 65, // Spacial Attack & Defense
				45 // Speed
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
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Fire-Blast",
				"Glare",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Magic-Coat",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Gyro-Ball",
				"Natural-Gift",
				"Trump-Card",
				"Last-Resort",
				"Poison-Jab",
				"Aqua-Tail",
				"Air-Slash",
				"Dragon-Rush",
				"Zen-Headbutt",
				"Captivate",
				"Stealth-Rock",
				"Charge-Beam",
				"Coil",
				"Round",
				"Hex",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Wild-Charge",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}