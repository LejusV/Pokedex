using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Poliwhirl Species to store common natural stats of all Poliwhirls
	#region PoliwhirlSpecies
	public class PoliwhirlSpecies : PokemonSpecies
	{
#nullable enable
		private static PoliwhirlSpecies? _instance = null;
#nullable restore
        public static PoliwhirlSpecies Instance => _instance ?? (_instance = new PoliwhirlSpecies());

		#region PoliwhirlSpecies Constructor
		public PoliwhirlSpecies() : base(
			61,
			"Poliwhirl",
			Water.Instance,
			1.0,
			20.0,
			new PokemonStats(
				65, // HPs
				65, 65, // Attack & Defense
				50, 50, // Spacial Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Waterfall",
				"Skull-Bash",
				"Amnesia",
				"Bubble",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
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
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Fling",
				"Mud-Bomb",
				"Captivate",
				"Round",
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