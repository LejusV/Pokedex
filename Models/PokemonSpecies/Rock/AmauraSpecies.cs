using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Amaura Species to store common natural stats of all Amauras
	#region AmauraSpecies
	public class AmauraSpecies : PokemonSpecies
	{
#nullable enable
		private static AmauraSpecies? _instance = null;
#nullable restore
        public static AmauraSpecies Instance => _instance ?? (_instance = new AmauraSpecies());

		#region AmauraSpecies Constructor
		public AmauraSpecies() : base(
			698,
			"Amaura",
			Rock.Instance, Ice.Instance,
			1.3,
			25.2,
			new PokemonStats(
				77, // HPs
				59, 50, // Attack & Defense
				67, 63, // Spacial Attack & Defense
				46 // Speed
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
				"Take-Down",
				"Growl",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Rock-Throw",
				"Toxic",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Iron-Defense",
				"Calm-Mind",
				"Water-Pulse",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Earth-Power",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Discharge",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}