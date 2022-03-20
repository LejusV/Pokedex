using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dragonair Species to store common natural stats of all Dragonairs
	#region DragonairSpecies
	public class DragonairSpecies : PokemonSpecies
	{
#nullable enable
		private static DragonairSpecies? _instance = null;
#nullable restore
        public static DragonairSpecies Instance => _instance ?? (_instance = new DragonairSpecies());

		#region DragonairSpecies Constructor
		public DragonairSpecies() : base(
			148,
			"Dragonair",
			Dragon.Instance,
			4.0,
			16.5,
			new PokemonStats(
				61, // HPs
				84, 65, // Attack & Defense
				70, 70, // Spacial Attack & Defense
				70 // Speed
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
				"Slam",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Draco-Meteor",
				"Captivate",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}