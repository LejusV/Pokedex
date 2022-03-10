using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ludicolo Species to store common natural stats of all Ludicolos
	#region SpeciesLudicolo
	public class SpeciesLudicolo : PokemonSpecies
	{
#nullable enable
		private static SpeciesLudicolo? _instance = null;
#nullable restore
        public static SpeciesLudicolo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLudicolo();
                }
                return _instance;
            }
        }

		#region SpeciesLudicolo Constructor
		public SpeciesLudicolo() : base(
			"Ludicolo",
			1.5,
			55.0,
			80, // HPs
			70, 70, // Attack & Defense
			90, 100, // Special Attack & Defense
			70		
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

	//Ludicolo PokemonInstance Class
	#region Ludicolo
	public class LudicoloInstance : PokemonInstance
	{
		#region Ludicolo Constructors
		/// <summary>
		/// Ludicolo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LudicoloInstance(string nickname, int level)
		: base(
				272,
				SpeciesLudicolo.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ludicolo Builder only waiting for a Level
		/// </summary>
		public LudicoloInstance(int level)
		: base(
				272,
				SpeciesLudicolo.Instance, // PokemonInstance Species
				"Ludicolo", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ludicolo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ludicolo() : base(
			272,
			SpeciesLudicolo.Instance, // PokemonInstance Species
			Water.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}