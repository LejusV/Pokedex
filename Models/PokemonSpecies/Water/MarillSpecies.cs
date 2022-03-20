using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Marill Species to store common natural stats of all Marills
	#region MarillSpecies
	public class MarillSpecies : PokemonSpecies
	{
#nullable enable
		private static MarillSpecies? _instance = null;
#nullable restore
        public static MarillSpecies Instance => _instance ?? (_instance = new MarillSpecies());

		#region MarillSpecies Constructor
		public MarillSpecies() : base(
			183,
			"Marill",
			Water.Instance, Fairy.Instance,
			0.4,
			8.5,
			new PokemonStats(
				70, // HPs
				20, 50, // Attack & Defense
				20, 50, // Spacial Attack & Defense
				40 // Speed
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Foresight",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Hyper-Voice",
				"Muddy-Water",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Captivate",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}