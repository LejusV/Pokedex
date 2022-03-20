using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Flaaffy Species to store common natural stats of all Flaaffys
	#region FlaaffySpecies
	public class FlaaffySpecies : PokemonSpecies
	{
#nullable enable
		private static FlaaffySpecies? _instance = null;
#nullable restore
        public static FlaaffySpecies Instance => _instance ?? (_instance = new FlaaffySpecies());

		#region FlaaffySpecies Constructor
		public FlaaffySpecies() : base(
			180,
			"Flaaffy",
			Electric.Instance,
			0.8,
			13.3,
			new PokemonStats(
				70, // HPs
				55, 55, // Attack & Defense
				80, 60, // Spacial Attack & Defense
				45 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Charge",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Power-Gem",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Cotton-Guard",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}