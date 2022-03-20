using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Poliwag Species to store common natural stats of all Poliwags
	#region PoliwagSpecies
	public class PoliwagSpecies : PokemonSpecies
	{
#nullable enable
		private static PoliwagSpecies? _instance = null;
#nullable restore
        public static PoliwagSpecies Instance => _instance ?? (_instance = new PoliwagSpecies());

		#region PoliwagSpecies Constructor
		public PoliwagSpecies() : base(
			60,
			"Poliwag",
			Water.Instance,
			0.6,
			12.4,
			new PokemonStats(
				40, // HPs
				50, 40, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				90 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Haze",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Amnesia",
				"Bubble",
				"Psywave",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Mud-Bomb",
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