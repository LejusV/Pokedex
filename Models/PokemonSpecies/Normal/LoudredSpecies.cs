using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Loudred Species to store common natural stats of all Loudreds
	#region LoudredSpecies
	public class LoudredSpecies : PokemonSpecies
	{
#nullable enable
		private static LoudredSpecies? _instance = null;
#nullable restore
        public static LoudredSpecies Instance => _instance ?? (_instance = new LoudredSpecies());

		#region LoudredSpecies Constructor
		public LoudredSpecies() : base(
			294,
			"Loudred",
			Normal.Instance,
			1.0,
			40.5,
			new PokemonStats(
				84, // HPs
				71, 43, // Attack & Defense
				71, 43, // Spacial Attack & Defense
				48 // Speed
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
				"Pound",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Overheat",
				"Rock-Tomb",
				"Howl",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Zen-Headbutt",
				"Captivate",
				"Smack-Down",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}