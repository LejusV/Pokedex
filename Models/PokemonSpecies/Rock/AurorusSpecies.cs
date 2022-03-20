using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aurorus Species to store common natural stats of all Auroruss
	#region AurorusSpecies
	public class AurorusSpecies : PokemonSpecies
	{
#nullable enable
		private static AurorusSpecies? _instance = null;
#nullable restore
        public static AurorusSpecies Instance => _instance ?? (_instance = new AurorusSpecies());

		#region AurorusSpecies Constructor
		public AurorusSpecies() : base(
			699,
			"Aurorus",
			Rock.Instance, Ice.Instance,
			2.7,
			225.0,
			new PokemonStats(
				123, // HPs
				77, 72, // Attack & Defense
				99, 92, // Spacial Attack & Defense
				58 // Speed
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
				"Thunder",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
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
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Dragon-Tail",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}