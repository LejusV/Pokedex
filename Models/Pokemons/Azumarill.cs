using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Azumarill Species to store common natural stats of all Azumarills
	#region SpeciesAzumarill
	public class SpeciesAzumarill : PokemonSpecies
	{
#nullable enable
		private static SpeciesAzumarill? _instance = null;
#nullable restore
        public static SpeciesAzumarill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAzumarill();
                }
                return _instance;
            }
        }

		#region SpeciesAzumarill Constructor
		public SpeciesAzumarill() : base(
			184,
			"Azumarill",
			0.8,
			28.5,
			100, // HPs
			50, 80, // Attack & Defense
			60, 80, // Special Attack & Defense
			50		
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
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
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
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
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
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Scald",
				"Bulldoze",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Azumarill PokemonInstance Class
	#region Azumarill
	public class AzumarillInstance : PokemonInstance
	{
		#region Azumarill Constructors
		/// <summary>
		/// Azumarill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AzumarillInstance(string nickname, int level)
		: base(
				SpeciesAzumarill.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azumarill Builder only waiting for a Level
		/// </summary>
		public AzumarillInstance(int level)
		: base(
				SpeciesAzumarill.Instance, // PokemonInstance Species
				"Azumarill", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azumarill Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AzumarillInstance() : base(
			SpeciesAzumarill.Instance, // PokemonInstance Species
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}