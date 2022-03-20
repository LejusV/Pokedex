using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Politoed Species to store common natural stats of all Politoeds
	#region PolitoedSpecies
	public class PolitoedSpecies : PokemonSpecies
	{
#nullable enable
		private static PolitoedSpecies? _instance = null;
#nullable restore
        public static PolitoedSpecies Instance => _instance ?? (_instance = new PolitoedSpecies());

		#region PolitoedSpecies Constructor
		public PolitoedSpecies() : base(
			186,
			"Politoed",
			Water.Instance,
			1.1,
			33.9,
			new PokemonStats(
				90, // HPs
				75, 75, // Attack & Defense
				90, 100, // Spacial Attack & Defense
				70 // Speed
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Waterfall",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Bounce",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}