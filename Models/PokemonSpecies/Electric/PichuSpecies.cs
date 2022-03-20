using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pichu Species to store common natural stats of all Pichus
	#region PichuSpecies
	public class PichuSpecies : PokemonSpecies
	{
#nullable enable
		private static PichuSpecies? _instance = null;
#nullable restore
        public static PichuSpecies Instance => _instance ?? (_instance = new PichuSpecies());

		#region PichuSpecies Constructor
		public PichuSpecies() : base(
			172,
			"Pichu",
			Electric.Instance,
			0.3,
			2.0,
			new PokemonStats(
				20, // HPs
				40, 15, // Attack & Defense
				35, 35, // Spacial Attack & Defense
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
				"Double-Slap",
				"Mega-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Counter",
				"Seismic-Toss",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Bide",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Reversal",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Wish",
				"Secret-Power",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Volt-Tackle",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Magnet-Rise",
				"Nasty-Plot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Disarming-Voice",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion
}