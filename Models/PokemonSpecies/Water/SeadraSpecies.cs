using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Seadra Species to store common natural stats of all Seadras
	#region SeadraSpecies
	public class SeadraSpecies : PokemonSpecies
	{
#nullable enable
		private static SeadraSpecies? _instance = null;
#nullable restore
        public static SeadraSpecies Instance => _instance ?? (_instance = new SeadraSpecies());

		#region SeadraSpecies Constructor
		public SeadraSpecies() : base(
			117,
			"Seadra",
			Water.Instance,
			1.2,
			25.0,
			new PokemonStats(
				55, // HPs
				65, 95, // Attack & Defense
				95, 45, // Spacial Attack & Defense
				85 // Speed
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
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Giga-Impact",
				"Flash-Cannon",
				"Captivate",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}