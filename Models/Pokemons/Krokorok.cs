using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Krokorok Species to store common natural stats of all Krokoroks
	#region SpeciesKrokorok
	public class SpeciesKrokorok : PokemonSpecies
	{
#nullable enable
		private static SpeciesKrokorok? _instance = null;
#nullable restore
        public static SpeciesKrokorok Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKrokorok();
                }
                return _instance;
            }
        }

		#region SpeciesKrokorok Constructor
		public SpeciesKrokorok() : base(
			"Krokorok",
			1.0,
			33.4,
			60, // HPs
			82, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			74		
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
				"Cut",
				"Sand-Attack",
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Aqua-Tail",
				"Earth-Power",
				"Shadow-Claw",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Krokorok PokemonInstance Class
	#region Krokorok
	public class KrokorokInstance : PokemonInstance
	{
		#region Krokorok Constructors
		/// <summary>
		/// Krokorok Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KrokorokInstance(string nickname, int level)
		: base(
				552,
				SpeciesKrokorok.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krokorok Builder only waiting for a Level
		/// </summary>
		public KrokorokInstance(int level)
		: base(
				552,
				SpeciesKrokorok.Instance, // PokemonInstance Species
				"Krokorok", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krokorok Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Krokorok() : base(
			552,
			SpeciesKrokorok.Instance, // PokemonInstance Species
			Ground.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}