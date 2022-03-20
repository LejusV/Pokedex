using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skrelp Species to store common natural stats of all Skrelps
	#region SkrelpSpecies
	public class SkrelpSpecies : PokemonSpecies
	{
#nullable enable
		private static SkrelpSpecies? _instance = null;
#nullable restore
        public static SkrelpSpecies Instance => _instance ?? (_instance = new SkrelpSpecies());

		#region SkrelpSpecies Constructor
		public SkrelpSpecies() : base(
			690,
			"Skrelp",
			Poison.Instance, Water.Instance,
			0.5,
			7.3,
			new PokemonStats(
				50, // HPs
				60, 60, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				30 // Speed
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
				"Tail-Whip",
				"Acid",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Waterfall",
				"Bubble",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Icy-Wind",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Bounce",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Toxic-Spikes",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Gunk-Shot",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Play-Rough",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}