using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Beartic Species to store common natural stats of all Beartics
	#region SpeciesBeartic
	public class SpeciesBeartic : PokemonSpecies
	{
#nullable enable
		private static SpeciesBeartic? _instance = null;
#nullable restore
        public static SpeciesBeartic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBeartic();
                }
                return _instance;
            }
        }

		#region SpeciesBeartic Constructor
		public SpeciesBeartic() : base(
			"Beartic",
			2.6,
			260.0,
			95, // HPs
			130, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
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
				"Ice-Punch",
				"Swords-Dance",
				"Cut",
				"Thrash",
				"Growl",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Sheer-Cold",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Stone-Edge",
				"Grass-Knot",
				"Aqua-Jet",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Icicle-Crash",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Beartic PokemonInstance Class
	#region Beartic
	public class BearticInstance : PokemonInstance
	{
		#region Beartic Constructors
		/// <summary>
		/// Beartic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BearticInstance(string nickname, int level)
		: base(
				614,
				SpeciesBeartic.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beartic Builder only waiting for a Level
		/// </summary>
		public BearticInstance(int level)
		: base(
				614,
				SpeciesBeartic.Instance, // PokemonInstance Species
				"Beartic", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beartic Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Beartic() : base(
			614,
			SpeciesBeartic.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}