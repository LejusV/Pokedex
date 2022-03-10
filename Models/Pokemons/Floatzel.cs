using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Floatzel Species to store common natural stats of all Floatzels
	#region SpeciesFloatzel
	public class SpeciesFloatzel : PokemonSpecies
	{
#nullable enable
		private static SpeciesFloatzel? _instance = null;
#nullable restore
        public static SpeciesFloatzel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFloatzel();
                }
                return _instance;
            }
        }

		#region SpeciesFloatzel Constructor
		public SpeciesFloatzel() : base(
			"Floatzel",
			1.1,
			33.5,
			85, // HPs
			105, 55, // Attack & Defense
			85, 50, // Special Attack & Defense
			115		
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
				"Ice-Punch",
				"Razor-Wind",
				"Headbutt",
				"Growl",
				"Roar",
				"Sonic-Boom",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Bulk-Up",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Ice-Fang",
				"Captivate",
				"Aqua-Jet",
				"Double-Hit",
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

	//Floatzel PokemonInstance Class
	#region Floatzel
	public class FloatzelInstance : PokemonInstance
	{
		#region Floatzel Constructors
		/// <summary>
		/// Floatzel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FloatzelInstance(string nickname, int level)
		: base(
				419,
				SpeciesFloatzel.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floatzel Builder only waiting for a Level
		/// </summary>
		public FloatzelInstance(int level)
		: base(
				419,
				SpeciesFloatzel.Instance, // PokemonInstance Species
				"Floatzel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floatzel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Floatzel() : base(
			419,
			SpeciesFloatzel.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}