using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Azurill Species to store common natural stats of all Azurills
	#region AzurillSpecies
	public class AzurillSpecies : PokemonSpecies
	{
#nullable enable
		private static AzurillSpecies? _instance = null;
#nullable restore
        public static AzurillSpecies Instance => _instance ?? (_instance = new AzurillSpecies());

		#region AzurillSpecies Constructor
		public AzurillSpecies() : base(
			298,
			"Azurill",
			Normal.Instance, Fairy.Instance,
			0.2,
			2.0,
			new PokemonStats(
				50, // HPs
				20, 40, // Attack & Defense
				20, 40, // Spacial Attack & Defense
				20 // Speed
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
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Sing",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Bubble",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Camouflage",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Muddy-Water",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Copycat",
				"Captivate",
				"Soak",
				"Round",
				"Scald",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}