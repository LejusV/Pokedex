using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Avalugg Species to store common natural stats of all Avaluggs
	#region AvaluggSpecies
	public class AvaluggSpecies : PokemonSpecies
	{
#nullable enable
		private static AvaluggSpecies? _instance = null;
#nullable restore
        public static AvaluggSpecies Instance => _instance ?? (_instance = new AvaluggSpecies());

		#region AvaluggSpecies Constructor
		public AvaluggSpecies() : base(
			713,
			"Avalugg",
			Ice.Instance,
			2.0,
			505.0,
			new PokemonStats(
				95, // HPs
				117, 184, // Attack & Defense
				44, 46, // Spacial Attack & Defense
				28 // Speed
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Sharpen",
				"Substitute",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Ice-Ball",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Water-Pulse",
				"Gyro-Ball",
				"Rock-Polish",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Wide-Guard",
				"After-You",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}