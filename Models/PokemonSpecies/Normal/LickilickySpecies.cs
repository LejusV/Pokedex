using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lickilicky Species to store common natural stats of all Lickilickys
	#region LickilickySpecies
	public class LickilickySpecies : PokemonSpecies
	{
#nullable enable
		private static LickilickySpecies? _instance = null;
#nullable restore
        public static LickilickySpecies Instance => _instance ?? (_instance = new LickilickySpecies());

		#region LickilickySpecies Constructor
		public LickilickySpecies() : base(
			463,
			"Lickilicky",
			Normal.Instance,
			1.7,
			140.0,
			new PokemonStats(
				110, // HPs
				85, 95, // Attack & Defense
				80, 95, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Bind",
				"Slam",
				"Stomp",
				"Headbutt",
				"Wrap",
				"Supersonic",
				"Disable",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Lick",
				"Fire-Blast",
				"Dream-Eater",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Wring-Out",
				"Me-First",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Power-Whip",
				"Captivate",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}