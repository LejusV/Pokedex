using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dratini Species to store common natural stats of all Dratinis
	#region DratiniSpecies
	public class DratiniSpecies : PokemonSpecies
	{
#nullable enable
		private static DratiniSpecies? _instance = null;
#nullable restore
        public static DratiniSpecies Instance => _instance ?? (_instance = new DratiniSpecies());

		#region DratiniSpecies Constructor
		public DratiniSpecies() : base(
			147,
			"Dratini",
			Dragon.Instance,
			1.8,
			3.3,
			new PokemonStats(
				41, // HPs
				64, 45, // Attack & Defense
				50, 50, // Spacial Attack & Defense
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
				"Bind",
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Supersonic",
				"Flamethrower",
				"Mist",
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
				"Haze",
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
				"Extreme-Speed",
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
				"Aqua-Jet",
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