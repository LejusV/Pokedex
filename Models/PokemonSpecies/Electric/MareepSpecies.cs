using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mareep Species to store common natural stats of all Mareeps
	#region MareepSpecies
	public class MareepSpecies : PokemonSpecies
	{
#nullable enable
		private static MareepSpecies? _instance = null;
#nullable restore
        public static MareepSpecies Instance => _instance ?? (_instance = new MareepSpecies());

		#region MareepSpecies Constructor
		public MareepSpecies() : base(
			179,
			"Mareep",
			Electric.Instance,
			0.6,
			7.8,
			new PokemonStats(
				55, // HPs
				40, 40, // Attack & Defense
				65, 45, // Spacial Attack & Defense
				35 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
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
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Flatter",
				"Facade",
				"Charge",
				"Secret-Power",
				"Odor-Sleuth",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Power-Gem",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Electroweb",
				"Wild-Charge",
				"Cotton-Guard",
				"Confide",
				"Eerie-Impulse",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion
}