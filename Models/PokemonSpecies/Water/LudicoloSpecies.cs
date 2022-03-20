using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ludicolo Species to store common natural stats of all Ludicolos
	#region LudicoloSpecies
	public class LudicoloSpecies : PokemonSpecies
	{
#nullable enable
		private static LudicoloSpecies? _instance = null;
#nullable restore
        public static LudicoloSpecies Instance => _instance ?? (_instance = new LudicoloSpecies());

		#region LudicoloSpecies Constructor
		public LudicoloSpecies() : base(
			272,
			"Ludicolo",
			Water.Instance, Grass.Instance,
			1.5,
			55.0,
			new PokemonStats(
				80, // HPs
				70, 70, // Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Metronome",
				"Waterfall",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Astonish",
				"Bullet-Seed",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Seed-Bomb",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}