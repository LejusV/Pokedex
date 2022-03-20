using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Horsea Species to store common natural stats of all Horseas
	#region HorseaSpecies
	public class HorseaSpecies : PokemonSpecies
	{
#nullable enable
		private static HorseaSpecies? _instance = null;
#nullable restore
        public static HorseaSpecies Instance => _instance ?? (_instance = new HorseaSpecies());

		#region HorseaSpecies Constructor
		public HorseaSpecies() : base(
			116,
			"Horsea",
			Water.Instance,
			0.4,
			8.0,
			new PokemonStats(
				30, // HPs
				40, 70, // Attack & Defense
				70, 25, // Spacial Attack & Defense
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
				"Razor-Wind",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Disable",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Dragon-Rage",
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
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Octazooka",
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
				"Muddy-Water",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Flash-Cannon",
				"Captivate",
				"Round",
				"Clear-Smog",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}