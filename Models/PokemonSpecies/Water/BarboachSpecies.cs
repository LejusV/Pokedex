using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Barboach Species to store common natural stats of all Barboachs
	#region BarboachSpecies
	public class BarboachSpecies : PokemonSpecies
	{
#nullable enable
		private static BarboachSpecies? _instance = null;
#nullable restore
        public static BarboachSpecies Instance => _instance ?? (_instance = new BarboachSpecies());

		#region BarboachSpecies Constructor
		public BarboachSpecies() : base(
			339,
			"Barboach",
			Water.Instance, Ground.Instance,
			0.4,
			1.9,
			new PokemonStats(
				50, // HPs
				48, 43, // Attack & Defense
				46, 41, // Spacial Attack & Defense
				60 // Speed
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
				"Headbutt",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Amnesia",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Sport",
				"Dragon-Dance",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}